import React from 'react';
import PropTypes from 'prop-types';
import styled from 'styled-components';

export const StyledImage = styled.img`
  min-width: 100px;
  width: ${({ width }) => `${width}px`};
  height: ${({ height }) => `${height}px` || 'auto'};
  list-style: none;
  background: black center center no-repeat;
  border-radius: 4px;
  margin-right: ${({ mr }) => `${mr}px` || '0px'};
  margin-left: ${({ ml }) => `${ml}px` || '0px'};
  margin-top: ${({ mt }) => `${mt}px` || '0px'};
  margin-bottom: ${({ mb }) => `${mb}px` || '0px'};
`;

const urlPlaceHolder = `https://via.placeholder.com/`;

const Image = ({ src, alt, width, height, mb, children }) => {
  return (
    <StyledImage
      mb={mb}
      width={width}
      src={src || `${urlPlaceHolder}${width}x${height}`}
      alt={alt}
      height={height}
    >
      {children}
    </StyledImage>
  );
};

Image.defaultProps = {
  alt: 'Here should be an image',
  height: '',
  mb: '0',
  children: null,
};

Image.propTypes = {
  children: PropTypes.element,
  src: PropTypes.string.isRequired,
  alt: PropTypes.string,
  width: PropTypes.string.isRequired,
  height: PropTypes.string,
  mb: PropTypes.string,
};

export default Image;
