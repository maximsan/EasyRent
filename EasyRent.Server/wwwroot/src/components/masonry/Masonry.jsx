import React from 'react';
import PropTypes from 'prop-types';
import MasonryComponent from 'react-masonry-component';
import classes from './Masonry.module.css';

const Masonry = ({ images, options }) => {
  const imgElements =
    images &&
    images.map(({ urls, id }) => (
      <li className={classes.Img} key={id}>
        <img src={urls && urls.small} alt='' />
      </li>
    ));

  return <MasonryComponent options={options}>{imgElements}</MasonryComponent>;
};

Masonry.propTypes = {};
Masonry.defaultProps = {};

export default Masonry;
