import React from 'react';
import PropTypes from 'prop-types';
import DefaultButton from './DefaultButton';

const ContainedButton = ({ children, extraClasses, ...rest }) => {
  return (
    <DefaultButton extraClasses={extraClasses} {...rest} variant='contained'>
      {children}
    </DefaultButton>
  );
};

ContainedButton.defaultProps = {
  extraClasses: {},
};

ContainedButton.propTypes = {
  children: PropTypes.node.isRequired,
  extraClasses: PropTypes.shape({}),
};

export default ContainedButton;
