import React, { useState } from 'react';
import PropTypes from 'prop-types';
import SignFormLayout from '../../layouts/SignFormLayout';
import SignUpOverlay from './SignUpOverlay';

const SignUpForm = ({ value, onChange, onSubmit, className }) => {
  return (
    <div className={className}>
      <SignFormLayout
        value={value}
        onChange={onChange}
        header='Create Account'
        hint='or use your email for registration:'
        onHandleClick={onSubmit}
      />
    </div>
  );
};

SignUpForm.propTypes = {};

SignUpForm.defaultProps = {};

export default SignUpForm;
