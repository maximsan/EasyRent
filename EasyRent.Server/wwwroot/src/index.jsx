import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
import MuiThemeProvider from '@material-ui/core/styles/MuiThemeProvider';
import App from './App';
import store from './store';
import * as serviceWorker from './serviceWorker';
import ErrorBoundary from './components/ErrorBoundary';

import theme from './themes/theme';
import './index.css';
// import { createBrowserHistory } from 'history';

ReactDOM.render(
  <Provider store={store}>
    <ErrorBoundary>
      <MuiThemeProvider theme={theme}>
        <App />
      </MuiThemeProvider>
    </ErrorBoundary>
  </Provider>,
  document.getElementById('root'),
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
