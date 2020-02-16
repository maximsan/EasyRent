import { createContext } from 'react';

export default createContext({
    signinRedirectCallback: () => {},
    logout: () => {},
    signoutRedirectCallback: () => {},
    isAuthenticated: () => {},
    signinRedirect: () => {},
    signinSilentCallback: () => {},
    createSigninRequest: () => {},
    getAuthorizationHeaderValue: async () => {},
});
