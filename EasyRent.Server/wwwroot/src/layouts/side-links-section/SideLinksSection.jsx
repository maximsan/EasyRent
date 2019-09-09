import React from 'react';
import PropTypes from 'prop-types';
import AddIcon from '../../components/icons/AddIcon';
import FavouritesIcon from '../../components/icons/FavouritesIcon';
import BookmarksIcon from '../../components/icons/BookmarksIcon';
import { SideSection, SideSectionItem, ItemCaption } from './styled';

const SideLinksSection = () => {
  return (
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
  );
};

export default SideLinksSection;
