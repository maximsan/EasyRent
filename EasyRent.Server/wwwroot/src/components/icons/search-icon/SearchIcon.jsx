import React from 'react';
import { makeStyles } from '@material-ui/core';
import PropTypes from 'prop-types';
import Icon from '../common/Icon';

const useClasses = makeStyles({
  root: {
    cursor: 'pointer',
    marginLeft: '0.25rem',
  },
});

const SearchIcon = ({ title, fontSize, ...rest }) => {
  const { root } = useClasses();

  return (
    <Icon
      svgIconClasses={{ root }}
      titleAccess={title}
      viewBox='0 0 24 24'
      {...rest}
    >
      <path fill='none' d='M0 0h24v24H0V0z' />
      <path d='M15.5 14h-.79l-.28-.27C15.41 12.59 16 11.11 16 9.5 16 5.91 13.09 3 9.5 3S3 5.91 3 9.5 5.91 16 9.5 16c1.61 0 3.09-.59 4.23-1.57l.27.28v.79l5 4.99L20.49 19l-4.99-5zm-6 0C7.01 14 5 11.99 5 9.5S7.01 5 9.5 5 14 7.01 14 9.5 11.99 14 9.5 14z' />
    </Icon>
  );
};

SearchIcon.defaultProps = {
  fontSize: '',
  title: '',
};

SearchIcon.propTypes = {
  fontSize: PropTypes.string,
  title: PropTypes.string,
};

export default SearchIcon;
