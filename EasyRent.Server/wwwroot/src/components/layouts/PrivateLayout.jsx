import React from 'react';
import PropTypes from 'prop-types';
import { Switch, Route } from 'react-router-dom';
import useLayoutStyles from './layout-styles';
import Home from '../home/Home';

const PrivateLayout = () => {
  const classes = useLayoutStyles();
  return (
    <div className={classes.main}>
      <Switch>
        <Route path='/' component={Home} />
      </Switch>
    </div>
  );
};

PrivateLayout.defaultProps = {};

PrivateLayout.propTypes = {
  children: PropTypes.node,
};

export default PrivateLayout;
