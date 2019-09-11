import React from 'react';
import PropTypes from 'prop-types';
import { IconButton, makeStyles } from '@material-ui/core';
import ChevronLeftIcon from '@material-ui/icons/ChevronLeft';
import ChevronRightIcon from '@material-ui/icons/ChevronRight';
import styles from './button.module.css';

const useClasses = makeStyles({
  root: {
    color: '#086574',
    fontSize: '2rem',
  },
});

const SideBarButton = ({ extraClasses, open, ...rest }) => {
  const { root } = useClasses();

  return (
    <IconButton {...rest} classes={{ ...extraClasses }}>
      {open ? (
        <ChevronLeftIcon classes={{ root }} />
      ) : (
        <ChevronRightIcon classes={{ root }} />
      )}
    </IconButton>
  );
};

SideBarButton.propTypes = {};

SideBarButton.defaultProps = {};

export default SideBarButton;
