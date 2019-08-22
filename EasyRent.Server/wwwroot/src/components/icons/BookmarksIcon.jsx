import React from 'react';
import PropTypes from 'prop-types';
import Icon from './Icon';
import customClasses from './icon.module.css';

const BookmarksIcon = () => {
  return (
    <Icon
      className={customClasses.fabRoot}
      href=''
      size='medium'
      fontSize='large'
      titleAccess='Go to bookmarks'
      viewBox='0 0 24 24'
    >
      <path fill='none' d='M0 0h24v24H0V0z' />
      <path d='M15 7v12.97l-4.21-1.81-.79-.34-.79.34L5 19.97V7h10m4-6H8.99C7.89 1 7 1.9 7 3h10c1.1 0 2 .9 2 2v13l2 1V3c0-1.1-.9-2-2-2zm-4 4H5c-1.1 0-2 .9-2 2v16l7-3 7 3V7c0-1.1-.9-2-2-2z' />
    </Icon>
  );
};

BookmarksIcon.defaultTypes = {};

BookmarksIcon.propTypes = {};

export default BookmarksIcon;
