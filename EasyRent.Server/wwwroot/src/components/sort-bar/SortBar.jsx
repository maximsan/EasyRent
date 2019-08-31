import React from 'react';
import { SortBarDiv } from './styled';
import SortDownIcon from '../icons/sort-icons/SortByDatesDownIcon';
import SortUpIcon from '../icons/sort-icons/SortByDatesUpIcon';

export default function SortBar({ isSortedByDates = true }) {
  const renderSortIcon = () => {
    return isSortedByDates ? (
      <SortDownIcon title='Start from the oldest' />
    ) : (
      <SortUpIcon title='Start from the freshest' />
    );
  };

  return (
    <SortBarDiv>
      <>
        {renderSortIcon()}
        <span>Sort by dates</span>
      </>
      <>
        {renderSortIcon()}
        <span>Sort by price</span>
      </>
    </SortBarDiv>
  );
}
