import React from 'react';
import { storiesOf } from '@storybook/react';
import Filter from './Filter';

storiesOf('Filter', module).add('Default filter', () => (
  <div
  // style={{
  //   display: 'flex',
  //   height: '400px',
  //   justifyContent: 'center',
  //   alignItems: 'center',
  // }}
  >
    <Filter />
  </div>
));
