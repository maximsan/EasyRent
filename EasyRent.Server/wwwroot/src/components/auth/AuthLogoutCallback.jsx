// This componet which finishes logout request.
import React, { useContext, useEffect } from 'react';
import AuthContext from '../../context/AuthContext';

const LogoutCallback = () => {
    const { signoutRedirectCallback } = useContext(AuthContext);

    useEffect(() => {
        signoutRedirectCallback();
    }, [signoutRedirectCallback]);

    return null;
};

export default LogoutCallback;
