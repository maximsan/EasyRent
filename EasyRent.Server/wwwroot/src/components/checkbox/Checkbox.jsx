import React from 'react';
import PropTypes from 'prop-types';
import { FormControlLabel, Checkbox } from '@material-ui/core';

const CustomCheckBox = ({ label, onChange, value, checked, classes }) => {
  return (
    <FormControlLabel
      classes={classes}
      control={<Checkbox onChange={onChange} value={value} checked={checked} />}
      label={label}
    />
  );
};

CustomCheckBox.propTypes = {
  label: PropTypes.string,
  onChange: PropTypes.func,
  value: PropTypes.any,
  classes: PropTypes.shape({}),
};

CustomCheckBox.defaultProps = {
  label: '',
  onChange: () => {},
};

export default CustomCheckBox;
