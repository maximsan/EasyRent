import React from 'react';
import { Switch, Route, Link } from 'react-router-dom';
import Main from '../../pages/main/Main';

const Home = () => {
  return (
    <div>
      <div>Now make someone happy is easy</div>
      <div>Free rent or gift </div>
      <div>
        <span>Place your ad</span>
        <br />
        <span>Give it a second chance</span>
        <br />
        <Link to='/main'>Go to Main</Link>
      </div>
      <Switch>
        <Route path='/main' exact component={Main} />
      </Switch>
    </div>
  );
};

export default Home;
