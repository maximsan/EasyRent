import React from 'react';
import PropTypes from 'prop-types';
import { styled } from '@material-ui/styles';
import { Button } from '@material-ui/core';

const StyledButton = styled(Button)({
  color: '#020f11',
});

const DefaultButton = ({ children, extraClasses, variant, ...rest }) => {
  return (
    <StyledButton {...rest} variant={variant} classes={{ ...extraClasses }}>
      {children}
    </StyledButton>
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
