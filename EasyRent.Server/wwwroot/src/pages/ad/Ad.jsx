import React from 'react';
import PropTypes from 'prop-types';
import SideBarContext from '../../context/SideBarContext';
import Header from '../../components/common/header/Header';
import Filter from '../../components/filter/Filter';
import SideBar from '../../components/side-bar/SideBar';
import SideLinksSection from '../../layouts/side-links-section/SideLinksSection';
import { useToggle } from '../../hooks';

const Advertisement = () => {
  const [isOpen, toggle] = useToggle();

  return (
    <>
      <Header />
      <div>
        <SideBarContext.Provider value={{ open: isOpen, toggle }}>
          <SideBar>
            <Filter />
          </SideBar>
        </SideBarContext.Provider>
        <SideLinksSection />
      </div>
    </>
  );
};

Advertisement.defaultProps = {};
Advertisement.propTyeps = {};

export default Advertisement;
