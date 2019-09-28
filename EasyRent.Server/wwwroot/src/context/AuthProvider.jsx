import React, { Component } from 'react';
import OpenIdIdentityService from '../services/OpenIdIdentityService';

const AuthContext = React.createContext({
  signinRedirectCallback: () => {},
  logout: () => {},
  signoutRedirectCallback: () => {},
  isAuthenticated: () => {},
  signinRedirect: () => {},
  signinSilentCallback: () => {},
  createSigninRequest: () => {},
});

export class AuthProvider extends Component {
  identityService;
  constructor(props) {
    super(props);
    this.identityService = new OpenIdIdentityService();
  }
  render() {
    return (
      <AuthContext.Provider value={this.identityService}>
        {this.props.children}
      </AuthContext.Provider>
    );
  }
}

export default class AuthConsumer extends Component {
  constructor(props) {
    super(props);
  }
  render() {
    return (
      <AuthProvider>
        <AuthContext.Consumer>{this.props.children}</AuthContext.Consumer>
      </AuthProvider>
    );
  }
}
