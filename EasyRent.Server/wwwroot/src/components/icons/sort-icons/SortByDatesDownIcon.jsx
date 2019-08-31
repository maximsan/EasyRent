import React from 'react';
import { makeStyles } from '@material-ui/core';
import PropTypes from 'prop-types';
import Icon from '../common/Icon';

const useClasses = makeStyles(() => ({
  root: {},
}));

const SortByDatesDownIcon = ({ fontSize, title, placement, ...rest }) => {
  const { root } = useClasses();

  return (
    <Icon
      svgIconClasses={{ root }}
      title={title}
      placement={placement}
      fontSize={fontSize}
      viewBox='0 0 320 512'
      {...rest}
    >
      <path d='M41 288h238c21.4 0 32.1 25.9 17 41L177 448c-9.4 9.4-24.6 9.4-33.9 0L24 329c-15.1-15.1-4.4-41 17-41z' />
    </Icon>
  );
};

SortByDatesDownIcon.defaultProps = {
  size: 'small',
  title: '',
};

SortByDatesDownIcon.propTypes = {
  title: PropTypes.string,
  size: PropTypes.string,
};

export default SortByDatesDownIcon;
