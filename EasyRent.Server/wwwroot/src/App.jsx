import React from 'react';
import { Switch, Route, BrowserRouter, Animate } from 'react-router-dom';
// import SignUp from './components/sign-up/SignUp';
// import Layout from './components/Layout';
import PublicLayout from './layouts/router-layouts/PublicLayout';
import PrivateLayout from './layouts/router-layouts/PrivateLayout';
import PrivateRoute from './components/PrivateRoute';
import AuthProvider from './context/AuthProvider';

const App = React.memo(() => (
  <AuthProvider>
    <BrowserRouter>
      <Switch>
        <Route path='/signin' component={PublicLayout} />
        <Route path='/signup' component={PublicLayout} />
        <Route path='/home' component={PublicLayout} />
        <PrivateRoute path='/' component={PrivateLayout} />
      </Switch>
    </BrowserRouter>
  </AuthProvider>
));

export default App;
