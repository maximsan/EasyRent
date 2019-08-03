import React, { Component } from 'react';
import { DividerHr } from './styled';

const Divider = ({ position, width, height }) => {
  return (
    <DividerHr
      top={0}
      right={0}
      width={width}
      height={height}
      position={position}
    />
  );
};

export default Divider;
