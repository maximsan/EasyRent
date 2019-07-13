import React from 'react';
import PropTypes from 'prop-types';
import { Button } from '@material-ui/core';
import classes from './button.module.css';

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

CustomButton.propTypes = {
  children: PropTypes.arrayOf({}).isRequired,
};

CustomButton.defaultProps = {};

export default CustomButton;
