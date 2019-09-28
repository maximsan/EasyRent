import React from 'react';
import { AuthConsumer } from '../../context/AuthProvider';

const AuthLogout = () => {
  <AuthConsumer>
    {(logout) => {
      logout();
      return <span>loading...</span>;
    }}
  </AuthConsumer>;
};

export default AuthLogout;
