import styled from 'styled-components';

export const Container = styled.div`
  width: 100%;
  padding-right: 15px;
  padding-left: 15px;
  margin-right: auto;
  margin-left: auto;
`;

export const MainSection = styled.main`
  min-height: 80%;
  height: 100%;
  width: 100vw;
  display: flex;
  justify-content: flex-start;
  flex-wrap: nowrap;
  position: relative;
  margin: 100px 20px 120px 20px;
`;

export const ContentSection = styled.section`
  position: relative;
  height: 900px;
  width: 800px;
  min-width: 70%;
  margin-left: ${({ open }) => (open ? `580` : `100`)}px;
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
  color: #196a39;
  letter-spacing: 1px;
  text-transform: uppercase;
`;
