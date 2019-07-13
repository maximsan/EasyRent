import React from 'react';
import PropTypes from 'prop-types';
import { Select, FormControl, MenuItem } from '@material-ui/core';

const CustomSelect = ({ items, value, onChange, name, children }) => {
  return (
    <FormControl>
      <Select value={value} onChange={onChange} displayEmpty name={name}>
        <MenuItem value=''>{children}</MenuItem>
        {items &&
          items.map((item) => (
            <MenuItem value={item.value}>{item.name}</MenuItem>
          ))}
      </Select>
    </FormControl>
  );
};

CustomSelect.propTypes = {
  value: PropTypes.string,
  name: PropTypes.string.isRequired,
  placeholder: PropTypes.string,
  onChange: PropTypes.func.isRequired,
  items: PropTypes.arrayOf({}).isRequired,
};

CustomSelect.defaultProps = {
  value: 'Sport equipment',
  placeholder: 'Select',
};

export default CustomSelect;
