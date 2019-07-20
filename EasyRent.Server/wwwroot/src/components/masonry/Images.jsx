import React, { Fragment } from 'react';
import PropTypes from 'prop-types';
import Masonry from './MasonryComponent';
import { ImgDiv } from './styled';

const Images = ({ images }) => {
  const imgElements =
    images &&
    images.map(({ urls, id }) => (
      <Fragment key={id}>
        <ImgDiv src={urls && urls.small} alt='' />
      </Fragment>
    ));

  return <Masonry minWidth={200}>{imgElements}</Masonry>;
};

Images.propTypes = {};
Images.defaultProps = {};

export default Images;
