import React, { Component } from 'react';

import { Switch, Route } from 'react-router-dom';
import GridStudents from './modules/students/container/students.grid';

class Routes extends Component {
  render() {
    return (
      <Switch>
        <Route exact paths="/alunos" component={GridStudents} />
      </Switch>
    );
  }
}

export default Routes;
