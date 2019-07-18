import React from 'react';
import MasonryComponent from 'react-masonry-component';
import classes from './Masonry.module.css';

const Masonry = ({ images }) => {
  const imgElements =
    images &&
    images.map(({ src }) => (
      <div className={classes.Img}>
        <img src={src} alt='' />
      </div>
    ));

  return <MasonryComponent>{imgElements}</MasonryComponent>;
};

export default Masonry;
