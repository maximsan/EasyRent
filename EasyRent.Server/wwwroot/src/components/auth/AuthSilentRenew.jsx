import React from 'react';
import AuthProvider from '../../context/AuthProvider';

const SilentRenew = () => (
  <AuthProvider>
    {({ signinSilentCallback }) => {
      signinSilentCallback();
      return <span>loading...</span>;
    }}
  </AuthProvider>
);

export default SilentRenew;
