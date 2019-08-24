import React from 'react';
import PropTypes from 'prop-types';
import { Fab, SvgIcon, makeStyles } from '@material-ui/core';

const useClasses = makeStyles({
  fabIconRoot: {
    color: '#020f11',
    border: '1.5px #e8f6f8 solid',
    background: '#fff',
    '&:hover': {
      background: '#e8f6f8',
    },
  },
});

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
  fabClasses,
  svgIconClasses,
  ...rest
}) => {
  const commonClasses = useClasses();

  return (
    <Fab
      classes={{ root: commonClasses.fabIconRoot, ...fabClasses }}
      className={className}
      size={size}
      variant={variant}
    >
      <SvgIcon
        {...rest}
        color={color}
        fontSize={fontSize}
        titleAccess={titleAccess}
        viewBox={viewBox}
        htmlColor={htmlColor}
        classes={svgIconClasses}
      >
        {children}
      </SvgIcon>
    </Fab>
  );
};

FabIcon.defaultTypes = {};

FabIcon.propTypes = {
  icon: PropTypes.node,
};

export default FabIcon;
