import React, { PureComponent } from 'react';
import PropTypes from 'prop-types';
import { Input, FormControl, FormLabel } from '@material-ui/core';

const InputGroup = ({ label, items }) => {
  return (
    <>
      <FormControl>
        <FormLabel>{label}</FormLabel>
        {items.map((item) => (
          <Input
            type='number'
            name={item.name}
            value={item.value}
            onChange={item.onChange}
            placeholder={item.placeholder}
          />
        ))}
      </FormControl>
    </>
  );
};

InputGroup.propTypes = {};

InputGroup.defaultProps = {};

export default InputGroup;
