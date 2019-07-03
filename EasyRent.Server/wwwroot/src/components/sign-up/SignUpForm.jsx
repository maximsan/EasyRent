import React, { useState } from 'react';
import PropTypes from 'prop-types';
import SignFormLayout from '../layouts/SignFormLayout';
import SignUpOverlay from './SignUpOverlay';

const SignUpForm = ({ value, onHandleChange, onSignUpSubmit, className }) => {
  return (
    <div className={className}>
      <SignFormLayout
        value={value}
        onHandleChange={onHandleChange}
        header='Create Account'
        hint='or use your email for registration:'
        onHandleClick={onSignUpSubmit}
      />
    </div>
  );
};

SignUpForm.propTypes = {};

SignUpForm.defaultProps = {};

export default SignUpForm;
