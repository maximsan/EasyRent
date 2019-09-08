import React from 'react';
import PropTypes from 'prop-types';
import Input from '../input/Input';
import StartIcon from '../../icons/StartIcon';

const Password = ({ startIcon, labelText, ...rest }) => {
  return (
    <Input
      id='password'
      type='password'
      labelText={labelText}
      {...rest}
      startAdornment={<StartIcon icon={startIcon} />}
    />
  );
};

Password.defaultTypes = {};

Password.propTypes = {
  startIcon: PropTypes.node.isRequired,
};

export default Password;
