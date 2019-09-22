import React from 'react';
import { Link } from 'react-router-dom';
import GeoLocationIcon from '../../icons/GeoLocationIcon';
import customClasses from './header.module.css';
import Search from '../search/Search';
// import AuthProvider from '../../../context/AuthProvider';
import DefaultButton from '../button/DefaultButton';
import SignInUpButton from '../button/SignInUpButton';

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
        {/* <SignInUpButton></SignInUpButton> */}
        {/* <AuthProvider render={({signinRedirect}) => {
          return <button onClick={signinRedirect}>Sign In / Sign Out</button>
        }}>
        </AuthProvider> */}
        {/* <DefaultButton children={children} onClick={AuthProvider.signinRedirect}>Sign In / Sign Out</DefaultButton> */}
      </div>
    </header>
  );
};

export default Header;
