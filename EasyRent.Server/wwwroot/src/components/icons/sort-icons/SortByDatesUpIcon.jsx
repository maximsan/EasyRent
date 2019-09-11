import React from 'react';
import PropTypes from 'prop-types';
import Icon from '../common/Icon';

const SortByDatesUpIcon = ({ fontSize, title, ...rest }) => {
  return (
    <Icon
      fontSize={fontSize}
      titleAccess={title}
      viewBox='0 0 320 512'
      {...rest}
    >
      <path d='M279 224H41c-21.4 0-32.1-25.9-17-41L143 64c9.4-9.4 24.6-9.4 33.9 0l119 119c15.2 15.1 4.5 41-16.9 41z' />
    </Icon>
  );
};

SortByDatesUpIcon.defaultProps = {
  size: 'small',
  title: '',
};

SortByDatesUpIcon.propTypes = {
  title: PropTypes.string,
  size: PropTypes.string,
};

export default SortByDatesUpIcon;
