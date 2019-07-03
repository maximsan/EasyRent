import React from 'react';
import { Button } from '@material-ui/core';
import classes from './button.module.scss';

const CustomButton = ({ children, addClasses, ...rest }) => {
  return (
    <Button
      {...rest}
      classes={{ ...classes, ...addClasses }}
      variant='contained'
    >
      {children}
    </Button>
  );
};

CustomButton.propTypes = {};

CustomButton.defaultProps = {};

export default CustomButton;
