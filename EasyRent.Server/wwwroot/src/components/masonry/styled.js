import styled from 'styled-components';

export const MasonryDiv = styled.div`
  width: 100%;
  position: absolute;
  display: grid;
  grid-auto-flow: column;
  grid-gap: ${(props) => {
    return props.gap || `0.5rem`;
  }};
`;

export const Col = styled.div`
  display: grid;
  grid-gap: ${(props) => {
    return props.gap || `0.5rem`;
  }};
  grid-auto-rows: max-content;
`;

export const ImgDiv = styled.img`
  height: auto;
  min-width: 100px;
  width: 240px;
  list-style: none;
  margin: 0 5px 5px 0;
  background-color: black;
  background-position: center center;
  background-repeat: no-repeat;
`;

export const container = styled.div`
  max-height: 140px;
  margin-top: 20px;
`;
