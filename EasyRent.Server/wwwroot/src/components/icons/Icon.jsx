import React from 'react';
import PropTypes from 'prop-types';
import { SvgIcon, makeStyles } from '@material-ui/core';
import customClasses from './icon.module.css';

const useClasses = makeStyles({
  root: {
    color: '#020f11',
  },
});

const Icon = ({
  size,
  variant,
  children,
  viewBox,
  titleAccess,
  fontSize,
  color,
  classNameSVG,
  className,
  htmlColor,
  classes,
  ...rest
}) => {
  const iconClasses = useClasses();

  return (
    <SvgIcon
      {...rest}
      color={color}
      fontSize={fontSize}
      titleAccess={titleAccess}
      viewBox={viewBox}
      htmlColor={htmlColor}
      classes={classes}
    >
      {children}
    </SvgIcon>
  );
};

Icon.defaultTypes = {};

Icon.propTypes = {
  icon: PropTypes.node,
};

export default Icon;
