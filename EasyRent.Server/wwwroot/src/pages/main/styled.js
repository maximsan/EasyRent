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

export const SideSection = styled.aside`
  min-width: 20vw;
  display: flex;
  flex-flow: column nowrap;
  justify-content: space-evenly;
  align-items: center;
`;

export const SideSectionItem = styled.div`
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
`;
