import React from 'react';
import AuthProvider from '../../context/AuthContext';

const AuthCallback = () => {
  return (
    <AuthProvider>
      {({ signinRedirectCallback }) => {
        signinRedirectCallback().then(() => {
          window.location = '/main';
        });
      }}
    </AuthProvider>
  );
};

export default AuthCallback;
