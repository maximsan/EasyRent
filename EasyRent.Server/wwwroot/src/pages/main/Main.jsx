import React, { useEffect, useState } from 'react';
import SideBarContext from '../../context/SideBarContext';
import axios from 'axios';
import {
  Container,
  ContentSection,
  MainSection,
  SideSection,
  SideSectionItem,
  ItemCaption,
} from './styled';
import Header from '../../components/header/Header';
import Filter from '../../components/filter/Filter';
import Images from '../../components/masonry/Images';
import Footer from '../../components/footer/Footer';
import SideBar from '../../components/side-bar/SideBar';
import AddIcon from '../../components/icons/AddIcon';
import FavouritesIcon from '../../components/icons/FavouritesIcon';
import BookmarksIcon from '../../components/icons/BookmarksIcon';
import useToggle from '../../hooks/useToggle';
import SortBar from '../../components/sort-bar/SortBar';

// Set config defaults when creating the instance
const instance = axios.create({
  baseURL: 'https://api.unsplash.com/',
});

const Main = () => {
  const [images, setImages] = useState(null);
  const [isOpen, toggle] = useToggle();

  useEffect(() => {
    const fetchImages = async () => {
      const { data } = await instance({
        method: 'get',
        url: `photos/?per_page=10&client_id=${process.env.REACT_APP_PHOTO_ACCESS_KEY}`,
      });
      setImages(data);
    };
    fetchImages();
  }, []);

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
          <Images images={images} />
        </ContentSection>
        <SideSection>
          <SideSectionItem>
            <AddIcon />
            <ItemCaption>Place an ad</ItemCaption>
          </SideSectionItem>
          <SideSectionItem>
            <BookmarksIcon />
            <ItemCaption>Go to bookmarks</ItemCaption>
          </SideSectionItem>
          <SideSectionItem>
            <FavouritesIcon />
            <ItemCaption>Go to favourite ads</ItemCaption>
          </SideSectionItem>
        </SideSection>
      </MainSection>
      <Footer />
    </>
  );
};

export default Main;
