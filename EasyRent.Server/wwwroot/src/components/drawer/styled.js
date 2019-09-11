import styled from 'styled-components';

export const DockedAside = styled.aside`
  height: 100%;
  flex: 0 0 auto;
  position: absolute;
  /* margin-top: 20px; */
  /* left: 0; */
  /* top: 120px; */
  /* bottom: 100px; */
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
  min-height: 770px;
  display: flex;
  flex: 1 0 auto;
  flex-direction: row;
  outline: none;
  -webkit-overflow-scrolling: touch;
  -webkit-box-shadow: 0px -4px 8px -1px rgba(0, 0, 0, 0.6),
    4px 0 8px -1px rgba(0, 0, 0, 0.6), 0 4px 8px -1px rgba(0, 0, 0, 0.6);
  -moz-box-shadow: 0px -4px 8px -1px rgba(0, 0, 0, 0.6),
    4px 0 8px -1px rgba(0, 0, 0, 0.6), 0 4px 8px -1px rgba(0, 0, 0, 0.6);
  box-shadow: 0px -4px 8px -1px rgba(0, 0, 0, 0.6),
    4px 0 8px -1px rgba(0, 0, 0, 0.6), 0 4px 8px -1px rgba(0, 0, 0, 0.6);
`;
