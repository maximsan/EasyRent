import React from 'react';
import PropTypes from 'prop-types';
import { Switch, Route } from 'react-router-dom';
import { CSSTransition, TransitionGroup } from 'react-transition-group';
import useLayoutStyles from './layout-styles';
import SignInUpForm from './SignInUpForm';

const PublicLayout = () => {
  const classes = useLayoutStyles();
  return (
    <div className={classes.main}>
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
      </Switch>
    </div>
  );
};

PublicLayout.defaultProps = {};

PublicLayout.propTypes = {
  children: PropTypes.node,
};

export default PublicLayout;
