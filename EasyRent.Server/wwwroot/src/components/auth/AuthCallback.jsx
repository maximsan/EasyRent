import React from 'react';
import { AuthConsumer } from '../../context/AuthProvider';

export const AuthCallback = () => {
  <AuthConsumer>
    {({ signinRedirectCallback }) => {
      signinRedirectCallback();
      return <span>loading...</span>;
    }}
  </AuthConsumer>;
};
