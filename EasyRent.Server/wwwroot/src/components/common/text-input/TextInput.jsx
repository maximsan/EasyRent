import React from 'react';
import PropTypes from 'prop-types';
import Input from '../input/Input';
import StartIcon from '../../icons/StartIcon';

const TextInput = ({ startIcon, id, labelText, ...rest }) => {
  return (
    <Input
      {...rest}
      id={id}
      type='text'
      labelText={labelText}
      startAdornment={<StartIcon icon={startIcon} />}
    />
  );
};

TextInput.defaultTypes = {};

TextInput.propTypes = {
  startIcon: PropTypes.node,
};

export default TextInput;
