import React from 'react';
import PaymentIcon from '../icons/PaymentIcon';
import GithubIcon from '../icons/socialIcons/GuthubIcon';
import GoogleIcon from '../icons/socialIcons/GoogleIcon';
import { Footer, SocilIcons } from './styled';

const FooterComponent = () => {
  return (
    <Footer>
      <PaymentIcon />
      <div>
        <span>Contact with us</span>
        <SocilIcons>
          <GoogleIcon />
          <GithubIcon />
        </SocilIcons>
      </div>
    </Footer>
  );
};

export default FooterComponent;
