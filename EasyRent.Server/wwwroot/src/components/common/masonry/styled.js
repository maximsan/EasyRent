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
