import { UserManager, Log, WebStorageStateStore } from 'oidc-client';

const IdentityServerUrl = process.env.IDENTITY_SERVER_URL;
const PublicUrl = process.env.PUBLIC_URL;

export default class OpenIdIdentityService {
  UserManager;
  accessToken;
  config = {
    authority: IdentityServerUrl,
    client_id: process.env.CLIENT_NAME,
    scope: `openid profile ${process.env.API_NAME}`,
    response_type: 'id_token token',
    loadUserInfo: true,
    redirect_uri: `${PublicUrl}/src/oidc/callback.html`,
    // login: `${process.env.PUBLIC_URL}/signin`,
    post_logout_redirect_uri: `${PublicUrl}/signin`,
    checkSessionInterval: 30000,
  };

  // metadata = {
  //   //issuer: "https://identityserver",
  //   jwks_uri: IdentityServerUrl + "/.well-known/openid-configuration/jwks",
  //   authorization_endpoint: IdentityServerUrl + "/connect/authorize",
  //   token_endpoint: IdentityServerUrl + "/connect/token",
  //   userinfo_endpoint: IdentityServerUrl + "/connect/userinfo",
  //   end_session_endpoint: IdentityServerUrl + "/connect/endsession",
  //   check_session_iframe: IdentityServerUrl + "/connect/checksession",
  //   revocation_endpoint: IdentityServerUrl + "/connect/revocation",
  //   introspection_endpoint: IdentityServerUrl + "/connect/introspect"
  // };

  constructor() {
    this.UserManager = new UserManager({
      // metadata: this.metadata,
      userStore: new WebStorageStateStore({
        store: window.localStorage,
      }),
      authority: this.config.authority,
      client_id: this.config.client_id,
      scope: this.config.scope,
      response_type: this.config.response_type,
      loadUserInfo: this.config.loadUserInfo,
      redirect_uri: this.config.redirect_uri,
      post_logout_redirect_uri: this.config.post_logout_redirect_uri,
      checkSessionInterval: this.config.checkSessionInterval,
    });

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
    const user = await this.UserManager.getUser();

    if (!user) {
      return await this.UserManager.signinRedirectCallback();
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

  signinRedirect = () => {
    localStorage.setItem('redirectUri', window.location.pathname);
    this.UserManager.signinRedirect({});
  };

  setUser = (data) => {
    localStorage.setItem('userId', data.sub);
  };

  navigateToScreen = () => {
    const redirectUri = !!localStorage.getItem('redirectUri')
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
    const access_token = localStorage.getItem('access_token');
    return !!access_token;
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
      window.location.replace(PublicUrl);
    });
    this.UserManager.clearStaleState();
  };
}
