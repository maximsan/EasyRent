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
  className,
  fabClasses,
  viewBox,
  titleAccess,
  fontSize,
  color,
  htmlColor,
  classNameSVG,
  svgIconClasses,
  children,
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

FabIcon.defaultProps = {
  children: React.createElement('div'),
  size: '',
  variant: '',
  className: '',
  fabClasses: '',
  viewBox: '',
  titleAccess: '',
  fontSize: 'inherit',
  color: 'inherit',
  htmlColor: '',
  classNameSVG: '',
  svgIconClasses: {},
};

FabIcon.propTypes = {
  children: PropTypes.node,
  size: PropTypes.string,
  variant: PropTypes.string,
  className: PropTypes.string,
  fabClasses: PropTypes.shape({}),
  viewBox: PropTypes.string,
  titleAccess: PropTypes.string,
  fontSize: PropTypes.string,
  color: PropTypes.string,
  htmlColor: PropTypes.string,
  classNameSVG: PropTypes.string,
  svgIconClasses: PropTypes.shape({}),
};

export default FabIcon;
