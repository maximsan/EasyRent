import React, { useContext } from 'react';
import { Link } from 'react-router-dom';
import GeoLocationIcon from '../../icons/GeoLocationIcon';
import customClasses from './header.module.css';
import Search from '../search/Search';
import DefaultButton from '../button/DefaultButton';
import AuthProvider, { AuthContext } from '../../../context/AuthContext';

const Header = ({ children }) => {
  const { isAuthenticated, signinRedirect } = useContext(AuthContext);

  const renderAuthButton = () => {
    debugger;
    if (isAuthenticated()) {
      return <span>You are authorized.</span>;
    }
    return <DefaultButton onClick={signinRedirect}>Sing in/out</DefaultButton>;
  };

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
      <div>{renderAuthButton()}</div>
    </header>
  );
};

export default Header;
