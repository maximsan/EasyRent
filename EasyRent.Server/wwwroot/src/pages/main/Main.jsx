import React, { useEffect, useState } from 'react';
import SideBarContext from '../../context/SideBarContext';
import { Container, ContentSection, MainSection } from './styled';
import Header from '../../components/common/header/Header';
import Filter from '../../components/filter/Filter';
import ImagesSection from '../../components/common/masonry/MasonrySection';
import Footer from '../../components/common/footer/Footer';
import SideBar from '../../components/side-bar/SideBar';
import SideLinksSection from '../../layouts/side-links-section/SideLinksSection';
import { useToggle, useFetch } from '../../hooks';
import SortBar from '../../components/sort-bar/SortBar';
import { url, METHODS } from '../../config';

const Main = () => {
  const [images, setImages] = useState(null);
  const [isOpen, toggle] = useToggle();

  const [data] = useFetch(METHODS.get, url);

  useEffect(() => {
    setImages(data);
  }, [data]);

  return (
    <>
      <Header />
      <MainSection>
        <SideBarContext.Provider value={{ open: isOpen, toggle }}>
          <SideBar>
            <Filter />
          </SideBar>
        </SideBarContext.Provider>
        <ContentSection open={isOpen}>
          <SortBar />
          <ImagesSection data={images} itemWidth={300} columnsCount={3} />
        </ContentSection>
        <SideLinksSection />
      </MainSection>
      <Footer />
    </>
  );
};

export default Main;
