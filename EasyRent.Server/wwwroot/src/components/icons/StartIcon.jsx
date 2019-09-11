import React from 'react';
import PropTypes from 'prop-types';
import { InputAdornment } from '@material-ui/core';

const StartIcon = ({ icon, ...rest }) => {
  return (
    <InputAdornment position='start' {...rest}>
      {icon}
    </InputAdornment>
  );
};

StartIcon.defaultProps = {};

StartIcon.propTypes = {
  icon: PropTypes.node.isRequired,
};

export default StartIcon;
