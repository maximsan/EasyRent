import React from 'react';
import { Grid, makeStyles } from '@material-ui/core';
import Header from '../header/Header';
import Filter from '../filter/Filter';
import Masonry from '../masonry/Masonry';

const useClasses = makeStyles({
  root: {
    minHeight: '100%',
  },
});

const Main = () => {
  const classes = useClasses();

  return (
    <Grid container classes={{ root: classes.root }}>
      <Header />
      <Filter />
      <Masonry />
    </Grid>
  );
};

export default Main;
