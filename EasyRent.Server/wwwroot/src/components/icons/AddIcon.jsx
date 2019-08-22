import React from 'react';
import PropTypes from 'prop-types';
import AddIcon from '@material-ui/icons/Add';
import FabIcon from './FabIcon';
import customClasses from './icon.module.css';

const CustomAddIcon = () => {
  return (
    <FabIcon
      className={customClasses.fabRoot}
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
