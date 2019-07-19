import React, { useEffect, useState } from 'react';
import { Grid, makeStyles } from '@material-ui/core';
import axios from 'axios';
import Header from '../header/Header';
import Filter from '../filter/Filter';
import Masonry from '../masonry/Masonry';

const useClasses = makeStyles({
  root: {
    minHeight: '100%',
  },
});

// Set config defaults when creating the instance
const instance = axios.create({
  baseURL: 'https://api.unsplash.com/',
});

const Main = () => {
  const classes = useClasses();
  const [images, setImages] = useState(null);

  useEffect(() => {
    const fetchImages = async () => {
      const { data } = await instance({
        method: 'get',
        url: `photos/?per_page=10&client_id=${process.env.REACT_APP_PHOTO_ACCESS_KEY}`,
      });
      setImages(data);
    };
    fetchImages();
  }, []);

  const masonryOptions = {
    transitionDuration: 0,
  };

  return (
    <Grid container classes={{ root: classes.root }}>
      <Header />
      <Filter />
      <Masonry options={masonryOptions} images={images} />
    </Grid>
  );
};

export default Main;
