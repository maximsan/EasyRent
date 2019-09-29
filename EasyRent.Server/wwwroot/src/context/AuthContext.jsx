import React, { createContext, useState } from 'react';
import PropTypes from 'prop-types';
import OpenIdIdentityService from '../services/OpenIdIdentityService';

export const AuthContext = createContext({
  signinRedirectCallback: () => {},
  logout: () => {},
  signoutRedirectCallback: () => {},
  isAuthenticated: () => {},
  signinRedirect: () => {},
  signinSilentCallback: () => {},
  createSigninRequest: () => {},
});

const AuthProvider = ({ children }) => {
  const [identityService] = useState(OpenIdIdentityService);

  return (
    <AuthContext.Provider value={identityService}>
      {children}
    </AuthContext.Provider>
  );
};

AuthProvider.propTypes = {
  children: PropTypes.any.isRequired,
};

export default AuthProvider;
