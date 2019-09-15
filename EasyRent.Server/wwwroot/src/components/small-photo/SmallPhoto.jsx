import React from 'react';
import PropTypes from 'prop-types';
import Image from '../common/image/Image';

const SmallPhoto = ({ width, height, mb }) => {
  return <Image width={width} height={height} mb={mb} />;
};

export default SmallPhoto;
