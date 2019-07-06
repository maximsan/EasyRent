import React from 'react';
import PropTypes from 'prop-types';
import { Switch, Route } from 'react-router-dom';
import useLayoutStyles from './layout-styles';
import Home from '../home/Home';
import Main from '../main/Main';

const PrivateLayout = () => {
  const classes = useLayoutStyles();
  return (
    <div className={classes.main}>
      <Switch>
        <Route exact path='/' component={Home} />
        <Route exact path='/main' component={Main} />
      </Switch>
    </div>
  );
};

PrivateLayout.defaultProps = {};

PrivateLayout.propTypes = {
  children: PropTypes.node,
};

export default PrivateLayout;
