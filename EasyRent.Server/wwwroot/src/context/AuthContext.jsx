import React, { createContext, useState } from 'react';
import OpenIdIdentityService from '../services/OpenIdIdentityService';
import PropTypes from 'prop-types';

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
