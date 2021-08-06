import React from 'react';
import { Switch, Route } from 'react-router-dom';
import Home from './pages/home';
import User from './pages/user';
import Poker from './pages/poker';
import Login from './pages/login';

export default function Routes() {
  return (
    <Switch>
      <Route path='/' exact component={Home} />
      <Route path='/user' component={User} />
      <Route path='/login' component={Login} />
      <Route path='/poker/:deckid' component={Poker} />
    </Switch>
  );
}
