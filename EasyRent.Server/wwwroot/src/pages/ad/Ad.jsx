import React from 'react';
import PropTypes from 'prop-types';
import SideBarContext from '../../context/SideBarContext';
import Header from '../../components/common/header/Header';
import Footer from '../../components/common/footer/Footer';
import Filter from '../../components/common/filter/Filter';
import SideBar from '../../components/common/side-bar/SideBar';
import { useToggle } from '../../hooks';
import BigPhoto from '../../components/big-photo/BigPhoto';
import {
  MainSection,
  SideSection,
  SideSectionItem,
  ItemCaption,
  AdSection,
  AdPreviewPhotoSection,
  AdBigPhotoSection,
  AdSideSection,
  AdSideSectionItem,
  AdSideSectionLabel,
} from './styled';
import FavouritesIcon from '../../components/icons/FavouritesIcon';
import BookmarksIcon from '../../components/icons/BookmarksIcon';
import ThumbUpIcon from '../../components/icons/ThumbUpIcon';
import Telegram from '../../components/icons/social-icons/TelegramIcon';
import SmallPhoto from '../../components/small-photo/SmallPhoto';
import { DefaultButton } from '../../components/common/button';

const Advertisement = () => {
  const [isOpen, toggle] = useToggle();

  const photoSideSection = (photos = 4) => {
    return Array(photos)
      .fill(0)
      .map((photo, index) => (
        <SmallPhoto mb='8' width='150' height='150' key={`$${index}`} />
      ));
  };

  return (
    <>
      <Header />
      <MainSection>
        <SideBarContext.Provider value={{ open: isOpen, toggle }}>
          <SideBar>
            <Filter />
          </SideBar>
        </SideBarContext.Provider>
        <AdSection>
          <AdPreviewPhotoSection>{photoSideSection()}</AdPreviewPhotoSection>
          <AdBigPhotoSection ml='12' mr='12'>
            <BigPhoto width='468' height='366' />
          </AdBigPhotoSection>
          <AdSideSection>
            <AdSideSectionLabel height='60'>Advertisement</AdSideSectionLabel>
            <AdSideSectionItem mb='12' height='500'>
              Description
            </AdSideSectionItem>
            <AdSideSectionItem mb='12' height='200'>
              How to contact
            </AdSideSectionItem>
            <AdSideSectionItem mb='12' height='200'>
              About seller
            </AdSideSectionItem>
            <DefaultButton>Make an order</DefaultButton>
          </AdSideSection>
        </AdSection>
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
