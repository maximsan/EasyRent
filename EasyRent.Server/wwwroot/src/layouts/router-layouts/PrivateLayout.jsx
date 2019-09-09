import React from 'react';
import PropTypes from 'prop-types';
import { Switch, Route } from 'react-router-dom';
import { LayoutDiv } from './styled';
import Home from '../../components/home/Home';
import Main from '../../pages/main/Main';
import Advertisement from '../../pages/ad/Ad';

const PrivateLayout = () => {
  return (
    <LayoutDiv>
      <Switch>
        <Route exact path='/' component={Home} />
        <Route exact path='/main' component={Main} />
        <Route exact path='/ad/:adId' component={Advertisement} />
      </Switch>
    </LayoutDiv>
  );
};

PrivateLayout.defaultProps = {};

PrivateLayout.propTypes = {
  children: PropTypes.node,
};

export default PrivateLayout;
