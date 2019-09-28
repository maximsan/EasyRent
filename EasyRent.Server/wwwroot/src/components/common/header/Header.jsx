import React from 'react';
import { Link } from 'react-router-dom';
import GeoLocationIcon from '../../icons/GeoLocationIcon';
import customClasses from './header.module.css';
import Search from '../search/Search';
import DefaultButton from '../button/DefaultButton';
import AuthConsumer from '../../../context/AuthProvider';

const Header = ({ children }) => {
  // AuthProvider.signinRedirect();
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
        <AuthConsumer>
          {({ isAuthenticated, signinRedirect }) => {
            if (isAuthenticated()) {
              return <span>You are authorized.</span>;
            } else {
              return <button onClick={signinRedirect}>Sing in/out</button>;
            }
          }}
        </AuthConsumer>
      </div>
    </header>
  );
};

export default Header;
