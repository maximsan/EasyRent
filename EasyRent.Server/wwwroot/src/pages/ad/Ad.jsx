import React from 'react';
import PropTypes from 'prop-types';
import SideBarContext from '../../context/SideBarContext';
import Header from '../../components/common/header/Header';
import Footer from '../../components/common/footer/Footer';
import Filter from '../../components/filter/Filter';
import SideBar from '../../components/side-bar/SideBar';
import SideLinksSection from '../../layouts/side-links-section/SideLinksSection';
import { useToggle } from '../../hooks';
import BigPhoto from '../../components/big-photo/BigPhoto';
import { MainSection } from './styled';

const Advertisement = () => {
  const [isOpen, toggle] = useToggle();

  return (
    <>
      <Header />
      <MainSection>
        <SideBarContext.Provider value={{ open: isOpen, toggle }}>
          <SideBar>
            <Filter />
          </SideBar>
        </SideBarContext.Provider>
        <BigPhoto />
        <SideLinksSection />
      </MainSection>
      <Footer />
    </>
  );
};

Advertisement.defaultProps = {};
Advertisement.propTyeps = {};

export default Advertisement;
