import React, { useState, useRef } from 'react';
import PropTypes from 'prop-types';
import useSignInClasses from './sign-in/signin-styles';
import SignInForm from './sign-in/SignInForm';
import SignInOverlay from './sign-in/SignInOverlay';
import SignUpForm from './sign-up/SignUpForm';
import SignUpOverlay from './sign-up/SignUpOverlay';
import classes from './SignInUp.module.css';

const SignInUpForm = () => {
  const [value, setValue] = useState({
    email: '',
    password: '',
    name: '',
  });

  const containerRef = useRef();

  const [isSignIn, setSignIn] = useState(true);

  const onHandleChange = (name) => (event) => {
    event.preventDefault();
    setValue({ [name]: event.target.value });
  };

  const onSignInSubmit = (props) => {
    console.log('onHandleSignInClick');
  };

  const onHandleSignUpClick = (props) => {
    containerRef.current.classList.add(`${classes.rightPanelActive}`);
    // window.location.pathname = 'signup';
  };

  const onHandleSignInClick = (props) => {
    containerRef.current.classList.remove(`${classes.rightPanelActive}`);
    // window.location.pathname = 'signin';
  };

  const onSignUpSubmit = (props) => {
    console.log('onHandleSignUpClick');
  };

  return (
    <div className={classes.container} ref={containerRef}>
      <SignUpForm
        className={`${classes.signUpContainer} ${classes.formContainer}`}
        value={value}
        onHandleChange={onHandleChange}
        onSignUpSubmit={onSignUpSubmit}
      />
      <SignInForm
        className={`${classes.signInContainer} ${classes.formContainer}`}
        value={value}
        isSignIn={isSignIn}
        onHandleChange={onHandleChange}
        onSignInSubmit={onSignInSubmit}
      />
      <div className={classes.overlayContainer}>
        <div className={classes.overlay}>
          <SignUpOverlay
            className={`${classes.overlayPanel} ${classes.overlayLeft}`}
            header='Welcome Back'
            hint='To keep connected with us please login with your personal info'
            buttonName='Sign In'
            onHandleClick={onHandleSignInClick}
          />
          <SignInOverlay
            className={`${classes.overlayPanel} ${classes.overlayRight}`}
            header='Hello, Friend!'
            hint='Enter your personal details and start journey with us'
            buttonName='Sign Up'
            onHandleClick={onHandleSignUpClick}
          />
        </div>
      </div>
    </div>
  );
};

export default SignInUpForm;
