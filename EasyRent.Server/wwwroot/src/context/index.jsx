import React from 'react';
import { Provider } from 'react-redux';
import { ThemeProvider } from '@material-ui/styles';
import theme from '../themes/theme';
import store from '../store';
import AuthProvider from './AuthProvider';

const Providers = ({ children } = {}) => (
  <ThemeProvider theme={theme}>
    <Provider store={store}>
      <AuthProvider>{children}</AuthProvider>
    </Provider>
  </ThemeProvider>
);

export default Providers;
