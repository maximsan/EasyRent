import React from 'react';
import PropTypes from 'prop-types';
import { Button } from '@material-ui/core';
import classes from './button.module.css';

const DefaultButton = ({ children, extraClasses, ...rest }) => {
  return (
    <Button {...rest} classes={{ ...extraClasses, ...classes }}>
      {children}
    </Button>
  );
};

DefaultButton.propTypes = {
  children: PropTypes.element.isRequired,
};

DefaultButton.defaultProps = {};

export default DefaultButton;
