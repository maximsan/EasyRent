import React from 'react';
import { Switch, Route, Link } from 'react-router-dom';
import Main from '../main/Main';

const Home = () => {
  return (
    <div>
      <div>Now make someone happy is easy</div>
      <div>Free rent or gift </div>
      <div>Place your ad</div>
      <div>
        <span>Give it a chance</span>
      </div>
      <div>
        <Link to='/main'>Go to Main</Link>
      </div>
      <Switch>
        <Route path='/main' exact component={Main} />
      </Switch>
    </div>
  );
};

export default Home;
