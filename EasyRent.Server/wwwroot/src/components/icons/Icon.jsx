import React from 'react';
import PropTypes from 'prop-types';
import { Fab, SvgIcon } from '@material-ui/core';
import useIconClasses from './Icon-styles';

const FabIcon = ({
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
  svgIconClasses,
  ...rest
}) => {
  const iconClasses = useIconClasses();

  return (
    <Fab classes={classes} className={className} size={size} variant={variant}>
      <SvgIcon
        {...rest}
        color={color}
        fontSize={fontSize}
        titleAccess={titleAccess}
        viewBox={viewBox}
        htmlColor={htmlColor}
        classes={{ root: iconClasses.root, ...svgIconClasses }}
      >
        {children}
      </SvgIcon>
    </Fab>
  );
};

FabIcon.defaultTypes = {};

FabIcon.propTypes = {
  icon: PropTypes.node.isRequired,
};

export default FabIcon;
