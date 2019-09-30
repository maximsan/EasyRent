import { UserManager, Log } from 'oidc-client';
import { METADATA_OIDC, IDENTITY_CONFIG } from '../config/oidc-config';
import { easyRentServerUrl } from '../config/constants';

class OpenIdIdentityService {
  UserManager;

  accessToken;

  constructor() {
    debugger;
    this.UserManager = new UserManager({
      ...IDENTITY_CONFIG,
      metadata: { ...METADATA_OIDC },
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
    window.localStorage.setItem('access_token', authResult.accessToken);
    window.localStorage.setItem('id_token', authResult.idToken);
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
      window.location.replace(easyRentServerUrl);
    });
    this.UserManager.clearStaleState();
  };
}

const openIdIdentityService = new OpenIdIdentityService();

export default openIdIdentityService;
