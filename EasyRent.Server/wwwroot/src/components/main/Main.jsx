import React from 'react';
import Header from '../header/Header';
import Filter from '../filter/Filter';
import { Grid, makeStyles } from '@material-ui/core';

const useClasses = makeStyles({
  root: {
    minHeight: '100vh',
    height: '100%',
  },
});

const Main = () => {
  const classes = useClasses();

  return (
    <Grid container classes={{ root: classes.root }}>
      <Header />
      <Filter />
    </Grid>
  );
};

export default Main;
