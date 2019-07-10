import React from 'react';
import PropTypes from 'prop-types';
import Input from '../input/Input';
import StartIcon from '../icons/StartIcon';

const Email = ({ startIcon, ...rest }) => {
  return (
    <Input
      {...rest}
      id='email'
      type='email'
      labelText='Email'
      startAdornment={<StartIcon icon={startIcon} />}
    />
  );
};

Email.defaultTypes = {};

Email.propTypes = {
  startIcon: PropTypes.node.isRequired,
};

export default Email;
