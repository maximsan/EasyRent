import React from 'react';
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core';
import FabIcon from './common/FabIcon';

const useClasses = makeStyles({
  fabIconRoot: {
    background: '#71B98E',
    cursor: 'pointer',
    '&:hover': {
      background: '#21914E',
    },
  },
  svgIconRoot: {
    '&:hover': {
      color: '#000',
    },
  },
});

const GeoLocationIcon = ({ size, fontSize, title, variant, ...rest }) => {
  const classes = useClasses();

  return (
    <FabIcon
      fabClasses={{ root: classes.fabIconRoot }}
      size={size}
      variant={variant}
      fontSize={fontSize}
      titleAccess={title}
      viewBox='0 0 24 24'
      svgIconClasses={{ root: classes.svgIconRoot }}
      {...rest}
    >
      <path fill='none' d='M0 0h24v24H0V0z' />
      <path d='M12 2C8.13 2 5 5.13 5 9c0 5.25 7 13 7 13s7-7.75 7-13c0-3.87-3.13-7-7-7zM7 9c0-2.76 2.24-5 5-5s5 2.24 5 5c0 2.88-2.88 7.19-5 9.88C9.92 16.21 7 11.85 7 9z' />
      <circle cx='12' cy='9' r='2.5' />
    </FabIcon>
  );
};

GeoLocationIcon.defaultProps = {
  size: 'medium',
  fontSize: 'default',
  title: '',
  variant: 'round',
};

GeoLocationIcon.propTypes = {
  size: PropTypes.string,
  fontSize: PropTypes.string,
  title: PropTypes.string,
  variant: PropTypes.string,
};

export default GeoLocationIcon;
