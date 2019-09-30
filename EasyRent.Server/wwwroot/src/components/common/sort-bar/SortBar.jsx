import React from 'react';
import { makeStyles } from '@material-ui/core';
import { SortBarDiv, SortBarDivItem, SortBySpan } from './styled';
import SortButton from '../button/SortButton';

const useClasses = makeStyles(() => ({
  root: {
    // marginBottom: '12px',
  },
}));

export default function SortBar({
  isSortedByDates = true,
  isSortedByPrices = true,
}) {
  const { root } = useClasses();

  return (
    <SortBarDiv>
      <SortBarDivItem>
        <SortButton
          iconButtonClasses={{ root }}
          isSorted={isSortedByDates}
          title1='Start from the oldest'
          title2='Start from the freshest'
        />
        <SortBySpan>Sort by dates</SortBySpan>
      </SortBarDivItem>
      <SortBarDivItem>
        <SortButton
          iconButtonClasses={{ root }}
          isSorted={isSortedByPrices}
          title1='Start from the most expensive'
          title2='Start from the cheapest'
        />
        <SortBySpan>Sort by price</SortBySpan>
      </SortBarDivItem>
    </SortBarDiv>
  );
}
