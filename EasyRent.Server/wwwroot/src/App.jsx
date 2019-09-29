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
        <Route
          path={`${process.env.PUBLIC_URL}/signin`}
          component={PublicLayout}
        />
        <Route
          path={`${process.env.PUBLIC_URL}/signup`}
          component={PublicLayout}
        />
        <Route
          path={`${process.env.PUBLIC_URL}/home`}
          component={PublicLayout}
        />

        <PrivateRoute path='/' component={PrivateLayout} />

        {/* <Route path='/signup' component={SignUp} />
      <Route path='/reset-password' />
      <Route path='/home' />
      <Route path='/main' />
      <Route path='/ad' />
      <Route path='/' component={SignIn} /> */}
      </Switch>
    </BrowserRouter>
  </AuthProvider>
));

export default App;
