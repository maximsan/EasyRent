import React from 'react';
import PropTypes from 'prop-types';
import { IconButton } from '@material-ui/core';
import SortDown from '../../icons/sort-icons/SortByDatesDownIcon';
import SortUp from '../../icons/sort-icons/SortByDatesUpIcon';
import DefaultButton from './DefaultButton';

const SortButton = ({
  iconButtonClasses,
  isSorted,
  children,
  title1,
  title2,
  size,
  ...rest
}) => {
  return (
    <>
      {isSorted ? (
        <SortDown fontSize='large' placement='top' title={title1} />
      ) : (
        <SortUp fontSize='large' placement='top' title={title2} />
      )}
    </>
  );
};

SortButton.propTypes = {};

SortButton.defaultProps = {};

export default SortButton;
