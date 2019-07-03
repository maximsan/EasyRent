import React from 'react';
import { Button } from '@material-ui/core';
import useButtonStyles from './button-styles';

const CustomButton = ({ children, addClasses, ...rest }) => {
  const classes = useButtonStyles();

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
