import React from 'react';
import PropTypes from 'prop-types';
import SideBarContext from '../../context/SideBarContext';
import Header from '../../components/common/header/Header';
import Footer from '../../components/common/footer/Footer';
import Filter from '../../components/filter/Filter';
import SideBar from '../../components/side-bar/SideBar';
import { useToggle } from '../../hooks';
import BigPhoto from '../../components/big-photo/BigPhoto';
import {
  MainSection,
  SideSection,
  SideSectionItem,
  ItemCaption,
} from './styled';
import FavouritesIcon from '../../components/icons/FavouritesIcon';
import BookmarksIcon from '../../components/icons/BookmarksIcon';
import ThumbUpIcon from '../../components/icons/ThumbUpIcon';
import Telegram from '../../components/icons/social-icons/TelegramIcon';

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
        <SideSection>
          <SideSectionItem>
            <BookmarksIcon />
            <ItemCaption>Go to bookmarks</ItemCaption>
          </SideSectionItem>
          <SideSectionItem>
            <FavouritesIcon />
            <ItemCaption>Go to favourite ads</ItemCaption>
          </SideSectionItem>
          <SideSectionItem>
            <ThumbUpIcon />
            <ItemCaption>Like</ItemCaption>
          </SideSectionItem>
          <SideSectionItem>
            <div>
              <Telegram />
              Viber Mobile
            </div>
            <ItemCaption>Contact an advertiser</ItemCaption>
          </SideSectionItem>
        </SideSection>
      </MainSection>
      <Footer />
    </>
  );
};

Advertisement.defaultProps = {};
Advertisement.propTyeps = {};

export default Advertisement;
