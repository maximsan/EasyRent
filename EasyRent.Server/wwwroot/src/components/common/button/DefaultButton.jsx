import React from 'react';
import PropTypes from 'prop-types';
import { Button } from '@material-ui/core';
import styles from './button.module.css';

const DefaultButton = ({ children, extraClasses, variant, ...rest }) => {
  return (
    <Button
      {...rest}
      className={styles.DefaultButton}
      variant={variant}
      classes={{ ...extraClasses }}
    >
      {children}
    </Button>
  );
};

DefaultButton.defaultProps = {
  extraClasses: {},
  variant: 'text',
};

DefaultButton.propTypes = {
  children: PropTypes.element.isRequired,
  extraClasses: PropTypes.shape({}),
  variant: PropTypes.string,
};

export default DefaultButton;
