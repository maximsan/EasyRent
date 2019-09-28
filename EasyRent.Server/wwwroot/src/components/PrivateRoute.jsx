import React from 'react';
import PropTypes from 'prop-types';
import { Route } from 'react-router-dom';
// import AuthConsumer from '../context/AuthProvider';

const PrivateRoute = ({ component: Component, ...rest }) => {
  return (
    <Route
      {...rest}
      render={(props) => {
        return <Component {...props} />;

        // return (
        //   <AuthConsumer>
        //     {({ isAuthenticated, signinRedirect }) => {
        //       if (!!Component && isAuthenticated()) {
        //         return <Component {...props} />;
        //       } else {
        //         signinRedirect();
        //         return <span>loading</span>;
        //       }
        //     }}
        //   </AuthConsumer>
        // );
      }}
    />
  );
};

PrivateRoute.defaultProps = {};

PrivateRoute.propTypes = {};

export default PrivateRoute;
