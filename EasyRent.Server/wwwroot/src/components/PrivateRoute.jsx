import React, { useContext } from 'react';
import PropTypes from 'prop-types';
import { Route, Redirect } from 'react-router-dom';
import AuthContext from '../context/AuthContext';

const PrivateRoute = ({ component: Component, ...rest }) => {
  const { isAuthenticated, signinRedirect } = useContext(AuthContext);

  return (
    <Route
      {...rest}
      render={({ location, ...props }) => {
        if (!!Component && isAuthenticated()) {
          return <Component {...props} />;
        }

        signinRedirect();
        //return <Redirect to='/signin' />; not need here.
        return <span>loading</span>;
      }}
    />
  );
};

PrivateRoute.propTypes = {
  component: PropTypes.element,
  location: PropTypes.object,
};

PrivateRoute.defaultProps = {};

export default PrivateRoute;
