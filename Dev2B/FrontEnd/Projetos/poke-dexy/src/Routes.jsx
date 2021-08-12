import React from 'react';
import { Route, Switch } from 'react-router-dom';
import Home from './pages/home';
import Pokemon from './pages/pokemon';

export default function Routes() {
  return (
    <Switch>
      <Route exact path="/" component={Home} />
      <Route exact path="/pokemon/:name" component={Pokemon} />
    </Switch>
  );
}
