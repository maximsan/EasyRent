import React, { Fragment } from 'react';
import PropTypes from 'prop-types';
import Masonry from './Masonry';
import Image from '../image/Image';

const MasonrySection = ({ data, itemWidth, columnsCount }) => {
  const imgElements =
    data &&
    data.map(({ urls, id }) => (
      <Fragment key={id}>
        <Image
          width={itemWidth}
          src={urls && urls.small}
          alt={urls && urls.small}
        />
      </Fragment>
    ));

  return (
    <Masonry columnsCount={columnsCount} width={itemWidth}>
      {imgElements}
    </Masonry>
  );
};

MasonrySection.defaultProps = {};

MasonrySection.propTypes = {};

export default MasonrySection;
