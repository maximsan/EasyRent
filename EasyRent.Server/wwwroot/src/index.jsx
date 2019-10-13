import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import Providers from './context';
import * as serviceWorker from './serviceWorker';
import ErrorBoundary from './components/helpers/ErrorBoundary';

import './index.css';
// import { createBrowserHistory } from 'history';

ReactDOM.render(
  <Providers>
    <ErrorBoundary>
      <App />
    </ErrorBoundary>
  </Providers>,
  document.getElementById('root'),
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
