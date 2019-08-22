import React from 'react';
import PropTypes from 'prop-types';
import BookmarksIcon from '@material-ui/icons/BookmarksOutlined';
import FabIcon from './FabIcon';
import customClasses from './icon.module.css';

const CustomBookmarksIcon = () => {
  return (
    <FabIcon
      className={customClasses.fabRoot}
      href=''
      size='medium'
      fontSize='medium'
      titleAccess=''
    >
      <BookmarksIcon />
    </FabIcon>
  );
};

CustomBookmarksIcon.defaultTypes = {};

CustomBookmarksIcon.propTypes = {};

export default CustomBookmarksIcon;
