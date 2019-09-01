import React from 'react';
import PropTypes from 'prop-types';
import DefaultButton from './DefaultButton';

const ContainedButton = ({ children, addClasses, ...rest }) => {
  return (
    <DefaultButton {...rest} variant='contained'>
      {children}
    </DefaultButton>
  );
};

ContainedButton.propTypes = {
  children: PropTypes.element.isRequired,
};

ContainedButton.defaultProps = {};

export default ContainedButton;
