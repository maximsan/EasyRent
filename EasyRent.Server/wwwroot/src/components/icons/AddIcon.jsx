import React from 'react';
import PropTypes from 'prop-types';
import AddIcon from '@material-ui/icons/Add';
import { makeStyles } from '@material-ui/core';
import FabIcon from './FabIcon';
import customClasses from './icon.module.css';

const useClasses = makeStyles((theme) => ({
  fabIconRoot: {
    background: '#c2e4e8',
    border: '1.5px solid #118fa3',
    boxShadow:
      '0px 3px 5px -1px rgba(17,143,163,0.2), 0px 6px 10px 0px rgba(17,143,163,0.14), 0px 1px 18px 0px rgba(17,143,163,0.12)',
    margin: theme.spacing(1),
    '&:hover': {
      background: '#fff',
      border: '1.5px #118fa3 solid',
    },
  },
}));

const CustomAddIcon = () => {
  const classes = useClasses();

  return (
    <FabIcon
      classes={{ root: classes.fabIconRoot }}
      href=''
      size='medium'
      fontSize='large'
      titleAccess=''
      variant='round'
    >
      <AddIcon />
    </FabIcon>
  );
};

CustomAddIcon.defaultTypes = {};

CustomAddIcon.propTypes = {};

export default CustomAddIcon;
