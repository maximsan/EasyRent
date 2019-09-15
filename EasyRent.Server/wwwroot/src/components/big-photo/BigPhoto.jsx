import React from 'react';
import PropTypes from 'prop-types';
import { LocationLabel } from './styled';
import Image from '../common/image/Image';
import ShareIcon from '../icons/share-icon/ShareIcon';

const BigPhoto = ({ location, width, height }) => {
  return (
    <>
      <Image width={width} height={height} />
      <ShareIcon />
      <LocationLabel>{location}</LocationLabel>
    </>
  );
};

export default BigPhoto;
