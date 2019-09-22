import AuthProvider from '../../../context/AuthProvider';
import React, { Component } from 'react';

export default class SignInButton extends Component {
  render() {
    <AuthProvider></AuthProvider>;
    return (
      <button onClick={AuthProvider.signinRedirect}>Sign In / Sign Out</button>
    );
  }
}
