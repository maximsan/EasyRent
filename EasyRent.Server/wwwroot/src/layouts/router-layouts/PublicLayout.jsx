import React from 'react';
import PropTypes from 'prop-types';
import { Switch, Route } from 'react-router-dom';
import { LayoutDiv } from './styled';
import SignInUpForm from '../../pages/sign-in-up/SignInUpForm';
import Home from '../../pages/home/Home';
import SideBar from '../../components/common/side-bar/SideBar';

const PublicLayout = () => {
  return (
    <LayoutDiv>
      {/* <Route
        render={({ location }) => (
          <TransitionGroup className={classes.page}>
            <CSSTransition
              key={location.key}
              timeout={30000}
              classNames={classes.fade}
            >
            </CSSTransition>
            </TransitionGroup>
        )} 
        />*/}
      <Switch>
        <Route path='/signin' exact component={SignInUpForm} />
        <Route path='/signup' exact component={SignInUpForm} />
        <Route path='/home' exact component={Home} />
        <Route path='/side-bar' exact component={SideBar} />
      </Switch>
    </LayoutDiv>
  );
};

PublicLayout.defaultProps = {};

PublicLayout.propTypes = {
  children: PropTypes.node,
};

export default PublicLayout;
