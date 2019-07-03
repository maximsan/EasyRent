import React, { useState } from 'react';
import { Paper } from '@material-ui/core';
import { CSSTransition, TransitionGroup } from 'react-transition-group';
import SignFormLayout from '../layouts/SignFormLayout';
import SignInOverlay from './SignInOverlay';

const SignInForm = ({
  value,
  onHandleChange,
  onSignInSubmit,
  isSignIn,
  className,
}) => {
  return (
    <div className={className}>
      <SignFormLayout
        value={value}
        isSignIn={isSignIn}
        onHandleChange={onHandleChange}
        header='Sing in to Easy Rent'
        hint='or use your email account:'
        onHandleClick={onSignInSubmit}
      />
    </div>
  );
};

SignInForm.propTypes = {};

SignInForm.defaultProps = {};

export default SignInForm;
