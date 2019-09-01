import React from 'react';
import { InputBase, makeStyles } from '@material-ui/core';
import StartIcon from '../icons/StartIcon';
import SearchIcon from '../icons/search-icon/SearchIcon';
import styles from './search.module.css';

const useClasses = makeStyles({
  root: {
    height: '42px',
    minWidth: '380px',
    maxWidth: '460px',
    width: '400px',
    flex: '1 1 400px',
    border: '1.5px solid #020f11',
    borderRadius: '8px',
    '&:hover': {
      border: '1.5px solid #21914e',
    },
  },
  input: {
    // color: 'red',
    '&::-webkit-search-decoration': {
      color: 'red',
      background: 'gold',
    },
  },
});

const Search = (labelText, placeholder, ...rest) => {
  const { root, input } = useClasses();

  return (
    <InputBase
      {...rest}
      classes={{ root, input }}
      startAdornment={
        <StartIcon icon={<SearchIcon title='Start your search...' />} />
      }
    />
  );
};

export default Search;
