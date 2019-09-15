import styled from 'styled-components';

export const DividerHr = styled.hr`
  position: ${(props) => props.position};
  height: ${(props) => props.height};
  width: ${(props) => props.width};
  top: ${(props) => props.top};
  bottom: ${(props) => props.bottom};
  right: ${(props) => props.right};
  left: ${(props) => props.left};
  border: none;
  flex-shrink: 0;
  background-color: rgba(0, 0, 0, 0.12);
`;
