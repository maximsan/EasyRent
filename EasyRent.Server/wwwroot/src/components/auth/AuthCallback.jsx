import { useContext, useEffect } from 'react';
import AuthContext from '../../context/AuthContext';

const AuthCallback = () => {
  const { signinRedirectCallback } = useContext(AuthContext);

  useEffect(() => {
    signinRedirectCallback()
      .then((state) => {
        window.location = '/main';
      })
      .catch((error) => {
        console.warn(error);
      });
  }, [signinRedirectCallback]);

  return null;
};

export default AuthCallback;
