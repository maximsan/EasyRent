import React from 'react';
import AuthConsumer from '../../context/AuthProvider';

const AuthCallback = () => {
  return (
    <AuthConsumer>
      {({ signinRedirectCallback }) => {
        signinRedirectCallback().then(() => {
          window.location = '/main';
        });
      }}
    </AuthConsumer>
  );


export default AuthCallback;
