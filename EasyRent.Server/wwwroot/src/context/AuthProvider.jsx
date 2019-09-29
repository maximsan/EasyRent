import React, { createContext, useState } from 'react';
import OpenIdIdentityService from '../services/OpenIdIdentityService';
import PropTypes from 'prop-types';

const AuthContext = createContext({
  signinRedirectCallback: () => {},
  logout: () => {},
  signoutRedirectCallback: () => {},
  isAuthenticated: () => {},
  signinRedirect: () => {},
  signinSilentCallback: () => {},
  createSigninRequest: () => {},
});

const AuthProvider = ({ children }) => {
  const [identityService] = useState({
    identityService: new OpenIdIdentityService(),
  });

  return (
    <AuthContext.Provider value={identityService}>
      {children}
    </AuthContext.Provider>
  );
};

AuthProvider.propTypes = {
  children: PropTypes.element.isRequired,
};

export default AuthProvider;
