import styled from 'styled-components';

export const Footer = styled.footer`
  width: 100%;
  min-height: 10vh;
  display: flex;
  justify-content: space-around;
  align-items: center;
  margin: 30px 0px 20px 0px;
  margin-left: ${({ open }) => (open ? `540` : `60`)}px;
`;

export const SocilIconsDiv = styled.div`
  display: flex;
  justify-content: space-around;
  margin-top: 0.5rem;
`;

export const ConstactSpan = styled.span`
  font-size: 0.7rem;
  font-weight: 600;
  word-spacing: 8px;
  color: #196a39;
  letter-spacing: 1px;
`;
