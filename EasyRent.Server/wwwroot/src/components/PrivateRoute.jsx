import React from 'react';
import PropTypes from 'prop-types';
import { Route } from 'react-router-dom';

const PrivateRoute = ({ component: Component, ...rest }) => {
  return (
    <Route {...rest} render={(props) => <Component {...props} {...rest} />} />
  );
};

PrivateRoute.defaultProps = {};

PrivateRoute.propTypes = {
  component: PropTypes.node,
};

export default PrivateRoute;
