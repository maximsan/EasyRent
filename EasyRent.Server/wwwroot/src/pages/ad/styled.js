import styled from 'styled-components';

export const MainSection = styled.main`
  width: 100%;
  display: flex;
  justify-content: flex-start;
  flex-wrap: nowrap;
  position: relative;
  margin: 100px 20px 80px 0px;
`;

export const SideSection = styled.aside`
  min-width: 20%;
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
