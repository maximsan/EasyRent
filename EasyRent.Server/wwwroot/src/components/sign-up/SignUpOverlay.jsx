import React from 'react';
import PropTypes from 'prop-types';
import { Grid, Paper } from '@material-ui/core';
import SignBackLayout from '../layouts/SignBackLayout';

const SignUpOverlay = ({
  header,
  buttonName,
  hint,
  onHandleClick,
  className,
  ...rest
}) => {
  return (
    <div className={className}>
      <SignBackLayout
        header={header}
        hint={hint}
        buttonName={buttonName}
        onHandleClick={onHandleClick}
        {...rest}
      />
    </div>
  );
};

export default SignUpOverlay;
