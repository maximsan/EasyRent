import React from 'react';
import PropTypes from 'prop-types';
import { Route } from 'react-router-dom';

const PrivateRoute = ({ component: Component, ...rest }) => {
  return (
    <Route
      {...rest}
      render={(props) => {
        return <Component {...props} {...rest} />;
      }}
    />
  );
};

PrivateRoute.defaultProps = {};

PrivateRoute.propTypes = {};

export default PrivateRoute;
