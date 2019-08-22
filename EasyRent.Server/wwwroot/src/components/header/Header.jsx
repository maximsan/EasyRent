import React from 'react';
import GeoLocationIcon from '../icons/GeoLocationIcon';
import customClasses from './header.module.css';
import Search from '../search/Search';
import { Switch, Route, Link } from 'react-router-dom';
import SignInUpForm from '../../pages/sign-in-up/SignInUpForm';

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
        <span>Choose your place</span>
      </div>
      <Link to='/signin'>Sign In / Sign Out</Link>
      <Switch>
        <Route path='/signin' exact component={SignInUpForm} />
      </Switch>
    </header>
  );
};

export default Header;
