import React from 'react';
import AuthProvider from '../../context/AuthContext';

const AuthLogout = () => (
  <AuthProvider>
    {({ logout }) => {
      logout();
      return <span>loading...</span>;
    }}
  </AuthProvider>
);

export default AuthLogout;
