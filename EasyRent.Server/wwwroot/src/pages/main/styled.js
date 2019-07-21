import styled from 'styled-components';

export const Container = styled.div`
  width: 100%;
  padding-right: 15px;
  padding-left: 15px;
  margin-right: auto;
  margin-left: auto;
`;

export const Row = styled.div`
  display: flex;
  flex-wrap: wrap;
  margin-right: -15px;
  margin-left: -15px;
`;

export const BodyCestion = styled.div`
  display: flex;
  flex-wrap: nowrap;
`;

export const MainSection = styled.main`
  position: relative;
  max-width: 800px;
  width: 800px;
  margin-top: 20px;
  overflow-y: scroll;
`;

export const Item = styled.div`
  margin: 0;
  padding: 0;
`;
