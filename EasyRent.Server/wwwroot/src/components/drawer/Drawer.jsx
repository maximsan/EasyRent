import React from 'react';
import { DockedDiv, RootDiv, MainDiv } from './styled';

const Drawer = ({ children, open }) => {
  return (
    <DockedDiv>
      <RootDiv>
        <MainDiv top='80px' left='60px' open={open}>
          {children}
        </MainDiv>
      </RootDiv>
    </DockedDiv>
  );
};

export default Drawer;
