import styled from 'styled-components';

export const DockedDiv = styled.div`
  flex: 0 0 auto;
`;

export const RootDiv = styled.div`
  color: rgba(0, 0, 0, 0.87);
  transition: box-shadow 300ms cubic-bezier(0.4, 0, 0.2, 1) 0ms;
  background-color: #fff;
`;

export const MainDiv = styled.div`
  position: fixed;
  top: ${(props) => props.top};
  bottom: ${(props) => props.bottom};
  left: ${(props) => props.left};
  right: ${(props) => props.right};
  z-index: 1200;
  height: 100%;
  display: flex;
  flex: 1 0 auto;
  flex-direction: column;
  outline: none;
  overflow-y: auto;
  -webkit-overflow-scrolling: touch;
`;
