import React from 'react';
import PropTypes from 'prop-types';
import { FormControl, FilledInput, InputLabel } from '@material-ui/core';
import useInputClasses from './input-styles';

const Input = ({
  id,
  type,
  labelText,
  variant,
  value,
  onChange,
  hasError,
  autoComplete,
  required,
  startAdornment,
}) => {
  const classes = useInputClasses();

  return (
    <FormControl
      classes={{ root: classes.formControlRoot }}
      required={required}
      variant={variant}
    >
      <InputLabel classes={{ focused: classes.focusedLabel }} htmlFor={id}>
        {labelText}
      </InputLabel>
      <FilledInput
        id={id}
        type={type}
        value={value}
        onChange={onChange}
        error={hasError}
        autoComplete={autoComplete}
        startAdornment={startAdornment}
        classes={{ focused: classes.focusedInput, root: classes.rootInput }}
      />
    </FormControl>
  );
};

Input.propTypes = {
  id: PropTypes.string.isRequired,
  value: PropTypes.string.isRequired,
  type: PropTypes.string.isRequired,
  onChange: PropTypes.func,
  hasError: PropTypes.bool,
  autoComplete: PropTypes.string,
  required: PropTypes.bool,
  variant: PropTypes.string,
  labelText: PropTypes.string,
  startAdornment: PropTypes.node,
};

Input.defaultProps = {
  onChange: () => {},
  hasError: false,
  autoComplete: '',
  startAdornment: {},
  required: false,
  variant: '',
  labelText: '',
};

export default Input;
