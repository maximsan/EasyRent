import React from 'react';
import PropTypes from 'prop-types';
import MasonryComponent from 'react-masonry-component';
import classes from './Masonry.module.css';

const Masonry = ({ images }) => {
  const imgElements =
    images &&
    images.slice(0, 20).map(({ title, url, id }) => (
      <div className={classes.Img} key={id}>
        <img src={url} alt='' title={title} />
      </div>
    ));

  return <MasonryComponent>{imgElements}</MasonryComponent>;
};

Masonry.propTypes = {};
Masonry.defaultProps = {};

export default Masonry;
