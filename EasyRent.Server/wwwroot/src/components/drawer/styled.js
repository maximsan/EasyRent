import styled from 'styled-components';

export const DockedAside = styled.aside`
  flex: 0 0 auto;
`;

export const RootDiv = styled.div`
  color: rgba(0, 0, 0, 0.87);
  transition: box-shadow 300ms cubic-bezier(0.4, 0, 0.2, 1) 0ms;
  background-color: #fff;
`;

export const MainDiv = styled.div`
  position: relative;
  padding: 10px 0px;
  top: ${(props) => props.top};
  bottom: ${(props) => props.bottom};
  left: ${(props) => props.left};
  right: ${(props) => props.right};
  z-index: 101;
  height: 100%;
  display: flex;
  flex: 1 0 auto;
  flex-direction: row;
  outline: none;
  -webkit-overflow-scrolling: touch;
  -webkit-box-shadow: 4px -4px 4px -1px rgba(0, 0, 0, 0.6);
  -moz-box-shadow: 4px -4px 4px -1px rgba(0, 0, 0, 0.6);
  box-shadow: 4px -4px 4px -1px rgba(0, 0, 0, 0.6);
`;
