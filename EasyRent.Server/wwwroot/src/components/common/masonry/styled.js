import styled from 'styled-components';

export const MasonryDiv = styled.div`
  width: ${({ width }) => `${width}px`};
  position: absolute;
  display: grid;
  grid-auto-flow: column;
  row-gap: ${({ gap }) => {
    return gap || `0.5rem`;
  }};
  overflow-y: scroll;
  height: 1000px;
  background: #c2e4e8;
`;

export const ColumnDiv = styled.div`
  display: grid;
  grid-gap: ${({ gap }) => {
    return gap || `0.5rem`;
  }};
  grid-auto-rows: max-content;
  justify-content: center;
  margin: ${({ marginColumnY, marginColumnX }) =>
    `${marginColumnY || 1}rem ${marginColumnX || 0}rem`};
  width: ${({ width }) => `${width}px`};
`;

export const ImageDiv = styled.img`
  height: auto;
  min-width: 100px;
  width: ${({ width }) => `${width}px`};
  list-style: none;
  background: black center center no-repeat;
  border-radius: 4px;
`;

export const ImagesDiv = styled.div`
  margin-top: 20px;
`;
