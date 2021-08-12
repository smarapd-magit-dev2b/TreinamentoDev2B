import { Switch, Route } from 'react-router-dom';

import Home from './pages/Home';
import User from './pages/User';
import Login from './pages/Login';
import Poker from './pages/Poker';

export default function Routes() {
  return (
    <Switch>
      <Route path="/" exact component={Home} />
      <Route path="/user" component={User} />
      <Route path="/login" component={Login} />
      <Route path="/poker/:deckid" component={Poker} />
    </Switch>
  )
}
