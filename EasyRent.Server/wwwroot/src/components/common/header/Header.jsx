import React, { useContext } from 'react';
import GeoLocationIcon from '../../icons/GeoLocationIcon';
import customClasses from './header.module.css';
import Search from '../search/Search';
import SignInLogout from '../../auth/SignInLogout';
import axios from 'axios';
import { easyRentServerUrl } from '../../../config/constants';
import DefaultButton from '../button/DefaultButton';
import AuthContex from '../../../context/AuthContext';

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
                <span className={customClasses.locationLabel}>
                    Choose your place
                </span>
            </div>
            <div>
                <SignInLogout />
            </div>
        </header>
    );
};

export default Header;
