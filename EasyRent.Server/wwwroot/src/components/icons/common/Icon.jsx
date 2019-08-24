import React from 'react';
import PropTypes from 'prop-types';
import { SvgIcon, makeStyles } from '@material-ui/core';
import styles from './icon.module.css';

const Icon = ({
  size,
  variant,
  children,
  viewBox,
  titleAccess,
  fontSize,
  color,
  className,
  classNameSVG,
  htmlColor,
  svgIconClasses,
  ...rest
}) => {
  return (
    <SvgIcon
      {...rest}
      color={color}
      fontSize={fontSize}
      titleAccess={titleAccess}
      viewBox={viewBox}
      htmlColor={htmlColor}
      classes={svgIconClasses}
      className={styles.svgIcon}
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
