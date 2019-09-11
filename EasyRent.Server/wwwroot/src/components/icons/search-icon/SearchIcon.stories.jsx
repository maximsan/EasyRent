import React from 'react';
import { storiesOf } from '@storybook/react';
import SearchIcon from './SearchIcon';

storiesOf('Icons', module).add('Default search icon', () => (
  <div
    style={{
      display: 'flex',
      height: '400px',
      justifyContent: 'center',
      alignItems: 'center',
    }}
  >
    <SearchIcon />
  </div>
));
