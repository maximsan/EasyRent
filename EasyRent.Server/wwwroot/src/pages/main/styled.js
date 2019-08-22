import styled from 'styled-components';

export const Container = styled.div`
  width: 100%;
  padding-right: 15px;
  padding-left: 15px;
  margin-right: auto;
  margin-left: auto;
`;

export const MainSection = styled.main`
  min-height: 80vh;
  height: 100%;
  width: 100vw;
  display: flex;
  justify-content: flex-start;
  flex-wrap: nowrap;
  position: relative;
  margin-top: 100px;
`;

export const ContentSection = styled.section`
  position: relative;
  width: 800px;
  min-width: 70vw;
  margin-left: 60px;
  margin-top: 20px;
  overflow-y: scroll;
`;
