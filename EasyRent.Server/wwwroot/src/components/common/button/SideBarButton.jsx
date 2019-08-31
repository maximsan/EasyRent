import React from 'react';
import PropTypes from 'prop-types';
import { IconButton } from '@material-ui/core';
import ChevronLeftIcon from '@material-ui/icons/ChevronLeft';
import ChevronRightIcon from '@material-ui/icons/ChevronRight';
import classes from './button.module.css';

const SideBarButton = ({ extraClasses, open, ...rest }) => {
  return (
    <IconButton {...rest} classes={{ ...extraClasses, ...classes }}>
      {open ? <ChevronLeftIcon /> : <ChevronRightIcon />}
    </IconButton>
  );
};

SideBarButton.propTypes = {};

SideBarButton.defaultProps = {};

export default SideBarButton;
