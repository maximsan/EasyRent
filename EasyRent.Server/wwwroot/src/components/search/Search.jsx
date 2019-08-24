import React from 'react';
import { InputBase, FormControl } from '@material-ui/core';
import Input from '../input/Input';
import StartIcon from '../icons/StartIcon';
import SearchIcon from '../icons/search-icon/SearchIcon';
import classes from './search.module.css';

const Search = (labelText, placeholder, ...rest) => {
  return (
    <InputBase
      {...rest}
      classes={{ root: classes.root }}
      type='search'
      startAdornment={<StartIcon icon={<SearchIcon />} />}
    />
  );
};

export default Search;
