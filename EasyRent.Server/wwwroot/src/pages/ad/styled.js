import styled from 'styled-components';

export const MainSection = styled.main`
  width: 100%;
  display: flex;
  justify-content: flex-start;
  flex-wrap: nowrap;
  position: relative;
  margin: 100px 20px 80px 0px;
`;

export const AdSection = styled.section`
  position: relative;
  height: 1000px;
  width: 800px;
  min-width: 70%;
  margin-left: ${({ open }) => (open ? `580` : `100`)}px;
  display: flex;
  flex-flow: row nowrap;
  align-items: center;
`;

export const SideSection = styled.aside`
  min-width: 20%;
  display: flex;
  flex-flow: column nowrap;
  justify-content: space-evenly;
  align-items: center;
`;

export const SideSectionItem = styled.section`
  display: flex;
  flex-flow: column;
  align-items: center;
`;

export const ItemCaption = styled.div`
  margin-top: 1.5rem;
  word-spacing: 2px;
  line-height: 24px;
  font-weight: 500;
  font-size: 1.2rem;
  color: #196a39;
  letter-spacing: 1px;
  text-transform: uppercase;
`;

export const AdPreviewPhotoSection = styled.section`
  height: 100%;
  display: flex;
  flex-flow: column nowrap;
  justify-content: center;
`;

export const AdBigPhotoSection = styled.section`
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
  flex-flow: column nowrap;
  margin-left: ${({ ml }) => `${ml}px`};
  margin-right: ${({ mr }) => `${mr}px`};
`;

export const AdSideSection = styled.section`
  height: 100%;
  width: 100%;
  display: flex;
  flex-flow: column nowrap;
  align-items: center;
  justify-content: center;
`;

export const AdSideSectionLabel = styled.div`
  height: ${({ height }) => (height ? `${height}px` : '100%')};
`;

export const AdSideSectionItem = styled.div`
  height: ${({ height }) => (height ? `${height}px` : '100%')};
  width: ${({ width }) => (width ? `${width}px` : `100%`)};
  border: 1.5px solid #086574;
  border-radius: 10px;
  margin-bottom: ${({ mb }) => `${mb}px`};
`;
