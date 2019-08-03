import React from 'react';
import PropTypes from 'prop-types';
import { makeStyles, Select, FormControl, MenuItem } from '@material-ui/core';
import customClasses from './Select.module.css';

const useClasses = makeStyles({
  root: {
    display: 'flex',
    height: '42px',
    width: '320px',
  },
});

const CustomSelect = ({ items, value, onChange, name, children }) => {
  const classes = useClasses();

  return (
    <FormControl classes={{ root: classes.root }}>
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
