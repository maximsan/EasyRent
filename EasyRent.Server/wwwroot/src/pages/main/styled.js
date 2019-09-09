import styled from 'styled-components';

export const Container = styled.div`
  width: 100%;
  padding-right: 15px;
  padding-left: 15px;
  margin-right: auto;
  margin-left: auto;
`;

export const MainSection = styled.main`
  width: 100%;
  display: flex;
  justify-content: flex-start;
  flex-wrap: nowrap;
  position: relative;
  margin: 100px 20px 80px 0px;
`;

export const ContentSection = styled.section`
  position: relative;
  height: 1000px;
  width: 800px;
  min-width: 70%;
  margin-left: ${({ open }) => (open ? `580` : `100`)}px;
`;
