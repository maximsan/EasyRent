import React from 'react';
import PropTypes from 'prop-types';
import { makeStyles, Input, FormControl, FormLabel } from '@material-ui/core';
import customClasses from './InputGroup.module.css';

const useClasses = makeStyles({
  inputRoot: {
    width: '120px',
  },
  formControlRoot: {
    margin: '20px 0',
  },
});

const InputGroup = ({ label, items }) => {
  const classes = useClasses();

  return (
    <>
      <FormControl classes={{ root: classes.formControlRoot }}>
        <FormLabel>{label}</FormLabel>
        <div className={customClasses.inputs}>
          {items.map(({ name, value, onChange, placeholder }) => (
            <Input
              classes={{ root: classes.inputRoot }}
              className={customClasses.input}
              type='number'
              name={name}
              value={value}
              onChange={onChange}
              placeholder={placeholder}
            />
          ))}
        </div>
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
