import React, { Component } from 'react';
import PropTypes from 'prop-types';
import CheckBox from './Checkbox';
import { FormGroup } from '@material-ui/core';

const CheckBoxGroup = ({ items }) => {
  return (
    <FormGroup>
      {items.map((item) => (
        <CheckBox
          label={item.label}
          onChange={item.onChange}
          value={item.value}
        />
      ))}
    </FormGroup>
  );
};

CheckBoxGroup.propTypes = {};

CheckBoxGroup.defaultProps = {};

export default CheckBoxGroup;
