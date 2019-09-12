import React from 'react';
import { Link } from 'react-router-dom';
import GeoLocationIcon from '../../icons/GeoLocationIcon';
import customClasses from './header.module.css';
import Search from '../search/Search';

const Header = ({ children }) => {
  return (
    <header className={customClasses.header}>
      {children}
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
        <span className={customClasses.locationLabel}>Choose your place</span>
      </div>
      <div>
        <Link to={`${process.env.PUBLIC_URL}/signin`}>Sign In / Sign Out</Link>
      </div>
      {/* <Switch>
        <Route path='/signin' exact component={SignInUpForm} />
      </Switch> */}
    </header>
  );
};

export default Header;
