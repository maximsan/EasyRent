import React, { useState } from 'react';
import PropTypes from 'prop-types';
import OpenIdIdentityService from '../services/OpenIdIdentityService';
import AuthContext from './AuthContext';

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
