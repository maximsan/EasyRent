import React, { Component } from 'react';
import PropTypes from 'prop-types';
import CheckBox from './Checkbox';
import { makeStyles, FormGroup } from '@material-ui/core';

const useClasses = makeStyles({
  formGroupRoot: {
    width: '320px',
    flexDirection: 'row',
  },
  checkboxRoot: {
    width: '150px',
  },
});

const CheckBoxGroup = ({ items }) => {
  const classes = useClasses();

  return (
    <FormGroup classes={{ root: classes.formGroupRoot }}>
      {items.map(({ label, name, value, onChange }) => (
        <CheckBox
          classes={{ root: classes.checkboxRoot }}
          label={label}
          name={name}
          value={value}
          onChange={onChange}
        />
      ))}
    </FormGroup>
  );
};

CheckBoxGroup.propTypes = {
  items: PropTypes.arrayOf({}).isRequired,
};

CheckBoxGroup.defaultProps = {};

export default CheckBoxGroup;
