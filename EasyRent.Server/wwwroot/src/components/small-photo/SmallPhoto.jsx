import React from 'react';
import PropTypes from 'prop-types';
import { Image } from './styled';

const SmallPhoto = ({ size }) => {
  return (
    <>
      <Image size={size} />
    </>
  );
};

export default SmallPhoto;
