import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import SideBarContext from '../../context/SideBarContext';
import Header from '../../components/common/header/Header';
import Filter from '../../components/common/filter/Filter';
import ImagesSection from '../../components/common/masonry/MasonrySection';
import Footer from '../../components/common/footer/Footer';
import SideBar from '../../components/common/side-bar/SideBar';
import { useToggle, useFetch } from '../../hooks';
import SortBar from '../../components/common/sort-bar/SortBar';
import { url, METHODS } from '../../config';
import AddIcon from '../../components/icons/AddIcon';
import FavouritesIcon from '../../components/icons/FavouritesIcon';
import BookmarksIcon from '../../components/icons/BookmarksIcon';
import {
  Container,
  ContentSection,
  MainSection,
  SideSection,
  SideSectionItem,
  ItemCaption,
} from './styled';
import AuthProvider from '../../context/AuthContext';

const MainPageRoute = `${process.env.PUBLIC_URL}/main`;

const Main = () => {
  const [images, setImages] = useState(null);
  const [isOpen, toggle] = useToggle();

  const [data] = useFetch(METHODS.get, url);

  useEffect(() => {
    setImages(data);
  }, [data]);

  return (
    <>
      <AuthProvider>
        <Header />
      </AuthProvider>
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
        <SideSection>
          <SideSectionItem>
            <Link to='/ad'>
              <AddIcon />
            </Link>
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
export { Main, MainPageRoute };
