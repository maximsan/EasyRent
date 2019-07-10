import React from 'react';
import GeoLocationIcon from '../icons/GeoLocationIcon';
import customClasses from './header.module.css';
import Search from '../search/Search';

const Header = () => {
  return (
    <header className={customClasses.header}>
      <div>
        <img src={{}} alt='' />
        <span>Easy Rent</span>
      </div>
      <div>
        <Search />
      </div>
      <div className={customClasses.location}>
        <div className={customClasses.locationIcon}>
          <GeoLocationIcon />
        </div>
        <span>Choose your place</span>
      </div>
    </header>
  );
};

export default Header;
