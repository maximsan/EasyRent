import React from 'react';
import PropTypes from 'prop-types';
import Icon from './common/Icon';

const BookmarkIcon = ({ fontSize, title, ...rest }) => {
  return (
    <Icon fontSize={fontSize} titleAccess={title} viewBox='0 0 24 24' {...rest}>
      <path fill='none' d='M0 0h24v24H0V0z' />
      <path d='M17 3H7c-1.1 0-2 .9-2 2v16l7-3 7 3V5c0-1.1-.9-2-2-2zm0 15l-5-2.18L7 18V5h10v13z' />
    </Icon>
  );
};

BookmarkIcon.defaultProps = {
  fontSize: 'large',
  title: 'Add bookmark',
};

BookmarkIcon.propTypes = {
  fontSize: PropTypes.string,
  title: PropTypes.string,
};

export default BookmarkIcon;
