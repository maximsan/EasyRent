import React from 'react';
import PropTypes from 'prop-types';
import { Switch, Route } from 'react-router-dom';
import { LayoutDiv } from './styled';
import Home from '../home/Home';
import Main from '../main/Main';

const PrivateLayout = () => {
  return (
    <LayoutDiv>
      <Switch>
        <Route exact path='/' component={Home} />
        <Route exact path='/main' component={Main} />
      </Switch>
    </LayoutDiv>
  );
};

PrivateLayout.defaultProps = {};

PrivateLayout.propTypes = {
  children: PropTypes.node,
};

export default PrivateLayout;
