import { UserManager, Log, WebStorageStateStore } from 'oidc-client';

const identityServerUrl = `${process.env.IDENTITY_SERVER_URL}`;
const publicUrl = `${process.env.EASY_RENT_API_URL}`;

class OpenIdIdentityService {
  UserManager;

  accessToken;

  config = {
    authority: identityServerUrl,
    client_id: 'client',
    scope: `openid profile api`,
    response_type: 'id_token token',
    loadUserInfo: true,
    redirect_uri: `${publicUrl}/singin`,
    // login: `${publicUrl}/signin`,
    post_logout_redirect_uri: `${publicUrl}/signin`,
    checkSessionInterval: 30000,
    userStore: new WebStorageStateStore({
      store: window.localStorage,
    }),
  };

  metadata = {
    // issuer: `https://identityserver`,
    jwks_uri: `${process.env.REACT_APP_AUTH_URL}/.well-known/openid-configuration/jwks`,
    authorization_endpoint: `${process.env.REACT_APP_AUTH_URL}/connect/authorize`,
    token_endpoint: `${process.env.REACT_APP_AUTH_URL}/connect/token`,
    userinfo_endpoint: `${process.env.REACT_APP_AUTH_URL}/connect/userinfo`,
    end_session_endpoint: `${process.env.REACT_APP_AUTH_URL}/connect/endsession`,
    check_session_iframe: `${process.env.REACT_APP_AUTH_URL}/connect/checksession`,
    revocation_endpoint: `${process.env.REACT_APP_AUTH_URL}/connect/revocation`,
    introspection_endpoint: `${process.env.REACT_APP_AUTH_URL}/connect/introspect`,
  };

  constructor() {
    this.UserManager = new UserManager(this.config);

    Log.logger = console;
    Log.level = 4;

    this.UserManager.events.addUserLoaded((user) => {
      this.accessToken = user.access_token;
      localStorage.setItem('access_token', user.access_token);
      localStorage.setItem('id_token', user.id_token);
      this.setUserInfo({
        accessToken: this.accessToken,
        idToken: user.id_token,
      });

      if (window.location.href.indexOf('signin-oidc') !== -1) {
        this.navigateToScreen();
      }
    });

    this.UserManager.events.addSilentRenewError((e) => {
      console.log('silent renew error', e.message);
    });

    this.UserManager.events.addAccessTokenExpired(() => {
      console.log('token expired');
      this.signinSilent();
    });
  }

  signinRedirectCallback = () => {
    this.UserManager.signinRedirectCallback().then(() => {
      '';
    });
  };

  getUser = async () => {
    let user = await this.UserManager.getUser();

    if (!user) {
      user = await this.UserManager.signinRedirectCallback();
      return user;
    }

    return user;
  };

  parseJwt = (token) => {
    const base64Url = token.split('.')[1];
    const base64 = base64Url.replace('-', '+').replace('_', '/');
    return JSON.parse(window.atob(base64));
  };

  setUserInfo = (authResult) => {
    const data = this.parseJwt(this.accessToken);

    this.setSessionInfo(authResult);
    this.setUser(data);
  };

  signinRedirect = (url) => {
    debugger;
    localStorage.setItem('redirectUri', url);
    this.UserManager.signinRedirect({});
  };

  setUser = (data) => {
    localStorage.setItem('userId', data.sub);
  };

  navigateToScreen = () => {
    const redirectUri = localStorage.getItem('redirectUri')
      ? localStorage.getItem('redirectUri')
      : '/en/dashboard';
    const language = '/' + redirectUri.split('/')[1];

    window.location.replace(language + '/dashboard');
  };

  setSessionInfo(authResult) {
    localStorage.setItem('access_token', authResult.accessToken);
    localStorage.setItem('id_token', authResult.idToken);
  }

  isAuthenticated = () => {
    const accessToken = localStorage.getItem('access_token');
    return !!accessToken;
  };

  signinSilent = () => {
    this.UserManager.signinSilent()
      .then((user) => {
        console.log('signed in', user);
      })
      .catch((err) => {
        console.log(err);
      });
  };

  signinSilentCallback = () => {
    this.UserManager.signinSilentCallback();
  };

  createSigninRequest = () => {
    return this.UserManager.createSigninRequest();
  };

  logout = () => {
    this.UserManager.signoutRedirect({
      id_token_hint: localStorage.getItem('id_token'),
    });
    this.UserManager.clearStaleState();
  };

  signoutRedirectCallback = () => {
    this.UserManager.signoutRedirectCallback().then(() => {
      localStorage.clear();
      window.location.replace(publicUrl);
    });
    this.UserManager.clearStaleState();
  };
}

const openIdIdentityService = new OpenIdIdentityService();

export default openIdIdentityService;
