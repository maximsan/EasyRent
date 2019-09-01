import React from 'react';
import PaymentIcon from '../icons/payment-icon/PaymentIcon';
import GithubIcon from '../icons/social-icons/GithubIcon';
import GoogleIcon from '../icons/social-icons/GoogleIcon';
import { Footer, SocilIconsDiv, ConstactSpan } from './styled';

const FooterComponent = ({ open }) => {
  return (
    <Footer open={open}>
      <PaymentIcon size='medium' fontSize='large' title='Make a donation' />
      <div>
        <ConstactSpan>Contact with us</ConstactSpan>
        <SocilIconsDiv>
          <GoogleIcon fontSize='large' title='Connect via Google' />
          <GithubIcon fontSize='large' title='Connect via Github' />
        </SocilIconsDiv>
      </div>
    </Footer>
  );
};

export default FooterComponent;
