import React, { useContext } from 'react';
import PropTypes from 'prop-types';
import { Route } from 'react-router-dom';
import AuthContext from '../context/AuthContext';

const PrivateRoute = ({ component: Component, ...rest }) => {
  const { isAuthenticated, signinRedirect } = useContext(AuthContext);

  return (
    <Route
      {...rest}
      render={(props) => {
        if (!!Component && isAuthenticated()) {
          return <Component {...props} />;
        }
        signinRedirect();
        return <span>loading...</span>;
      }}
    />
  );
};

PrivateRoute.defaultProps = {};

PrivateRoute.propTypes = {};

export default PrivateRoute;
