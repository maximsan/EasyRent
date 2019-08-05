import React from 'react';
import { DockedDiv, RootDiv, MainDiv } from './styled';

const Drawer = ({ children, className, open }) => {
  return (
    <DockedDiv className={className}>
      <RootDiv>
        <MainDiv top='80px' open={open}>
          {children}
        </MainDiv>
      </RootDiv>
    </DockedDiv>
  );
};

export default Drawer;
