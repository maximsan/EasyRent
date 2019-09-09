import React from 'react';
import PropTypes from 'prop-types';
import { Image, LocationLabel } from './styled';
import ShareIcon from '../icons/share-icon/ShareIcon';

const BigPhoto = ({ size, location }) => {
  return (
    <>
      <Image />
      <LocationLabel>{location}</LocationLabel>
      <ShareIcon />
    </>
  );
};

export default BigPhoto;
