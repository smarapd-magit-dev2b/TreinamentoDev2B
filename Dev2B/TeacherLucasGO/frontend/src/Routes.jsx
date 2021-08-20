import React from 'react';
import { Route, Switch } from 'react-router-dom';
import Login from './modules/user/container/Login';

export default function Routes() {
  return (
    <Switch>
      <Route path="/login" component={Login} />
      <Route path="/" component={Login} />
    </Switch>
  );
}
