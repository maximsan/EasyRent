import React from 'react';
import { Switch, Route, Link } from 'react-router-dom';
import { Main, MainPageRoute } from '../../pages/main/Main';

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
        <Link to={MainPageRoute}>Go to Main</Link>
      </div>
      <Switch>
        <Route path={MainPageRoute} exact component={Main} />
      </Switch>
    </div>
  );
};

export default Home;
