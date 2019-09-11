import React from 'react';
import { storiesOf } from '@storybook/react';
import PaymentIcon from './PaymentIcon';

storiesOf('Icons', module).add('Default payment icon', () => (
  <div
    style={{
      display: 'flex',
      height: '400px',
      justifyContent: 'center',
      alignItems: 'center',
    }}
  >
    <PaymentIcon />
  </div>
));
