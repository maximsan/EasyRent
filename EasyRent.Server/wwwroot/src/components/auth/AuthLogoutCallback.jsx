import React from 'react';
import AuthProvider from '../../context/AuthContext';

const LogoutCallback = () => (
  <AuthProvider>
    {({ signoutRedirectCallback }) => {
      signoutRedirectCallback();
      return <span>loading</span>;
    }}
  </AuthProvider>
);

export default LogoutCallback;
