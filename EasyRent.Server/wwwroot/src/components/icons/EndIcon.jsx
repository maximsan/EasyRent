import React from 'react';
import PropTypes from 'prop-types';
import { InputAdornment } from '@material-ui/core';

const EndIcon = ({ icon, ...rest }) => {
  return (
    <InputAdornment position='end' {...rest}>
      {icon}
    </InputAdornment>
  );
};

EndIcon.defaultTypes = {};

EndIcon.propTypes = {
  icon: PropTypes.node.isRequired,
};

export default EndIcon;
