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
  width: 250px;
  list-style: none;
  margin: 0 5px 5px 0;
  background-color: black;
  background-position: center center;
  background-repeat: no-repeat;
  border-radius: 4px;
`;

export const ImagesDiv = styled.div`
  margin-top: 20px;
`;
