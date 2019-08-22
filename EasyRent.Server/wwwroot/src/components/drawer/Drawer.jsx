import React from 'react';
import { DockedAside, RootDiv, MainDiv } from './styled';

const Drawer = ({ children, className, open }) => {
  return (
    <DockedAside className={className}>
      <MainDiv open={open}>{children}</MainDiv>
    </DockedAside>
  );
};

export default Drawer;
