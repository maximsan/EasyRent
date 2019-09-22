import React from 'react';
import { AuthConsumer } from '../../context/AuthProvider';

export const LogoutCallback = () => (
  <AuthConsumer>
    {({ signoutRedirectCallback }) => {
      signoutRedirectCallback();
      return <span>loading</span>;
    }}
  </AuthConsumer>
);
