import React, { Fragment } from 'react';
import PropTypes from 'prop-types';
import Masonry from './Masonry';
import { ImageDiv, ImagesDiv } from './styled';

const MasonrySection = ({ data, itemWidth, columnsCount }) => {
  const imgElements =
    data &&
    data.map(({ urls, id }) => (
      <Fragment key={id}>
        <ImageDiv width={itemWidth} src={urls && urls.small} alt='' />
      </Fragment>
    ));

  return (
    <Masonry columnsCount={columnsCount} width={itemWidth}>
      {imgElements}
    </Masonry>
  );
};

MasonrySection.defaultProps = {};

MasonrySection.propTypes = {
  // data: PropTypes.arrayOf(PropTypes.objectOf({})).isRequired,
};

export default MasonrySection;
