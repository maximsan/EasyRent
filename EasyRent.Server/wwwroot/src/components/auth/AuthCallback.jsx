import { useContext, useEffect } from 'react';
import AuthContext from '../../context/AuthContext';

const AuthCallback = () => {
  const { signinRedirectCallback } = useContext(AuthContext);

  useEffect(() => {
    signinRedirectCallback();
  }, [signinRedirectCallback]);

  return null;
};

export default AuthCallback;
