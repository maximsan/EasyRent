import React from 'react';
import { Switch, Route, BrowserRouter, Animate } from 'react-router-dom';
// import SignUp from './components/sign-up/SignUp';
// import Layout from './components/Layout';
import PublicLayout from './layouts/PublicLayout';
import PrivateLayout from './layouts/PrivateLayout';
import PrivateRoute from './components/PrivateRoute';
import SideBar from './components/side-bar/SideBar';

const App = React.memo(() => (
  <BrowserRouter>
    <Switch>
      <Route path='/signin' component={PublicLayout} />
      <Route path='/signup' component={PublicLayout} />
      <Route path='/home' component={PublicLayout} />
      <Route path='/side-bar' component={SideBar} />
      <PrivateRoute path='/' component={PrivateLayout} />
      {/* <Route path='/signup' component={SignUp} />
      <Route path='/reset-password' />
      <Route path='/home' />
      <Route path='/main' />
      <Route path='/ad' />
      <Route path='/' component={SignIn} /> */}
    </Switch>
  </BrowserRouter>
));

export default App;
