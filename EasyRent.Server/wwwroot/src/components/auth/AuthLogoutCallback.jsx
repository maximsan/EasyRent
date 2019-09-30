import React from 'react';
import AuthProvider from '../../context/AuthProvider';

const LogoutCallback = () => (
  <AuthProvider>
    {({ signoutRedirectCallback }) => {
      signoutRedirectCallback();
      return <span>loading</span>;
    }}
  </AuthProvider>
);

export default LogoutCallback;
