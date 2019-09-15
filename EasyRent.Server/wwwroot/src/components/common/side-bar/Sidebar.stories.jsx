import React from 'react';

import { storiesOf } from '@storybook/react';
import SideBar from './SideBar';
import Filter from '../filter/Filter';
import SidebarContext from '../../context/SideBarContext';

storiesOf('SideBar', module)
  .add('Open side bar', () => (
    <SidebarContext.Provider value={{ open: true }}>
      <SideBar>
        <Filter />
      </SideBar>
    </SidebarContext.Provider>
  ))
  .add('Close side bar', () => (
    <SidebarContext.Provider value={{ open: false }}>
      <SideBar>
        <Filter />
      </SideBar>
    </SidebarContext.Provider>
  ));
