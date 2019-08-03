import React, { useState, useRef } from 'react';
import PropTypes from 'prop-types';
import { connect, useDispatch } from 'react-redux';
import { signIn, signUp } from '../reducers/signInReducer';
import SignInForm from './sign-in/SignInForm';
import SignInOverlay from './sign-in/SignInOverlay';
import SignUpForm from './sign-up/SignUpForm';
import SignUpOverlay from './sign-up/SignUpOverlay';
import classes from './SignInUp.module.css';

const SignInUpForm = () => {
  const [values, setValues] = useState({
    email: '',
    password: '',
    confirmPassword: '',
    userName: '',
  });

  const dispatch = useDispatch();

  const containerRef = useRef();

  const [isSignIn, setSignIn] = useState(true);

  const onChange = (name) => (event) => {
    event.persist();
    setValues((prevValues) => ({ ...prevValues, [name]: event.target.value }));
    // setValues({ [name]: event.target.value });
  };

  const onSignInSubmit = (props) => {
    dispatch(signIn({ email: values.email, password: values.password }));
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
    dispatch(
      signUp({
        userName: values.userName,
        email: values.email,
        password: values.password,
        confirmPassword: values.confirmPassword,
      }),
    );
  };

  return (
    <div className={classes.container} ref={containerRef}>
      <SignUpForm
        className={`${classes.signUpContainer} ${classes.formContainer}`}
        value={values}
        onChange={onChange}
        onSubmit={onSignUpSubmit}
      />
      <SignInForm
        className={`${classes.signInContainer} ${classes.formContainer}`}
        value={values}
        isSignIn={isSignIn}
        onChange={onChange}
        onSubmit={onSignInSubmit}
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

SignInUpForm.propTypes = {
  dispatch: PropTypes.func,
};

SignInUpForm.defaultProps = {
  dispatch: () => {},
};

export default connect()(SignInUpForm);
