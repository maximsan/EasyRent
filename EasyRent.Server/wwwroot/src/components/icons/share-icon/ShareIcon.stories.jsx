import React from 'react';
import { storiesOf } from '@storybook/react';
import ShareIcon from './ShareIcon';

storiesOf('Icons', module).add('Default share icon', () => (
  <div
    style={{
      display: 'flex',
      height: '400px',
      justifyContent: 'center',
      alignItems: 'center',
    }}
  >
    <ShareIcon />
  </div>
));
