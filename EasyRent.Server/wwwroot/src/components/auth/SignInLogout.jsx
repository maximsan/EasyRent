//Component which returnes button for signing in or loging out.
import React, { useContext } from 'react';
import AuthContext from '../../context/AuthContext';
import DefaultButton from '../common/button/DefaultButton';

const SignInLogout = () => {
    const { isAuthenticated, logout, signinRedirect } = useContext(AuthContext);

    if (isAuthenticated()) {
        return <DefaultButton onClick={logout}>Logout</DefaultButton>; //<button onClick={logout}>Logout</button>;
    } else {
        return <DefaultButton onClick={signinRedirect}>Sing In</DefaultButton>; //<button onClick={signinRedirect}>Logout</button>;
    }
};

export default SignInLogout;
