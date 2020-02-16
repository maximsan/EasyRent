import { UserManager, Log } from 'oidc-client';
import { METADATA_OIDC, IDENTITY_CONFIG } from '../config/oidc-config';
import { easyRentServerUrl } from '../config/constants';

class OpenIdIdentityService {
    constructor() {
        this.UserManager = new UserManager({
            ...IDENTITY_CONFIG,
            metadata: { ...METADATA_OIDC },
        });

        Log.logger = console;
        Log.level = Log.DEBUG;

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
            console.warn('silent renew error', e.message);
        });

        this.UserManager.events.addAccessTokenExpired(() => {
            console.warn('token expired');
            this.signinSilent();
        });
    }

    signinRedirectCallback = () => {
        this.UserManager.signinRedirectCallback()
            .then((user) => {
                this.user = user;
                window.location.href = '/main';
            })
            .catch((error) => {
                Log.warn(error);
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

    getAuthorizationHeaderValue = async () => {
        let user = await this.getUser();
        return 'Bearer ' + user.access_token;
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
        localStorage.setItem('redirectUri', window.location.origin);
        this.UserManager.signinRedirect();
    };

    setUser = (userId) => {
        localStorage.setItem('userId', userId.sub);
    };

    navigateToScreen = () => {
        const redirectUri =
            localStorage.getItem('redirectUri') || '/en/dashboard';
        const language = `/${redirectUri.split('/')[1]}`;

        window.location.replace(`${language}/dashboard`);
    };

    setSessionInfo = ({ accessToken, idToken }) => {
        window.localStorage.setItem('access_token', accessToken);
        window.localStorage.setItem('id_token', idToken);
    };

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
                console.error(err);
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
    };

    signoutRedirectCallback = () => {
        this.UserManager.signoutRedirectCallback().then(() => {
            localStorage.clear();
            window.location.replace(`${easyRentServerUrl}/main`);
        });
        this.UserManager.clearStaleState();
    };
}

const openIdIdentityService = new OpenIdIdentityService();

export default openIdIdentityService;
