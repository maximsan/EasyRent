import React from 'react';
import PropTypes from 'prop-types';
import { SvgIcon, makeStyles } from '@material-ui/core';
import styles from './icon.module.css';

const Icon = ({
  viewBox,
  titleAccess,
  fontSize,
  color,
  htmlColor,
  svgIconClasses,
  children,
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

Icon.defaultProps = {
  children: React.createElement('path'),
  viewBox: '',
  titleAccess: '',
  fontSize: '',
  color: '',
  htmlColor: '',
  svgIconClasses: {},
};

Icon.propTypes = {
  children: PropTypes.node,
  viewBox: PropTypes.string,
  titleAccess: PropTypes.string,
  fontSize: PropTypes.string,
  color: PropTypes.string,
  htmlColor: PropTypes.string,
  svgIconClasses: PropTypes.shape({}),
};

export default Icon;
