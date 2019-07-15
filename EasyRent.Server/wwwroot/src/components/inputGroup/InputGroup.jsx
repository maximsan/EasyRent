import React from 'react';
import PropTypes from 'prop-types';
import { Input, FormControl, FormLabel } from '@material-ui/core';

const InputGroup = ({ label, items }) => {
  return (
    <>
      <FormControl>
        <FormLabel>{label}</FormLabel>
        {items.map(({ name, value, onChange, placeholder }) => (
          <Input
            type='number'
            name={name}
            value={value}
            onChange={onChange}
            placeholder={placeholder}
          />
        ))}
      </FormControl>
    </>
  );
};

InputGroup.propTypes = {
  items: PropTypes.arrayOf({}),
  label: PropTypes.string,
};

InputGroup.defaultProps = {
  label: '',
};

export default InputGroup;
