import React from 'react';
import PropTypes from 'prop-types';
import { FormControlLabel, Checkbox } from '@material-ui/core';

const CustomCheckBox = ({ label, onChange, value, checked }) => {
  return (
    <FormControlLabel
      control={<Checkbox onChange={onChange} value={value} checked={checked} />}
      label={label}
    />
  );
};

CustomCheckBox.propTypes = {};

CustomCheckBox.defaultProps = {};

export default CustomCheckBox;
