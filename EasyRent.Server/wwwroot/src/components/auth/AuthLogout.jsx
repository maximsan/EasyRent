import React from 'react';
import { AuthConsumer } from '../../context/AuthProvider';

export const AuthLogout = () => {
  <AuthConsumer>
    {(logout) => {
      logout();
      return <span>loading...</span>;
    }}
  </AuthConsumer>;
};
