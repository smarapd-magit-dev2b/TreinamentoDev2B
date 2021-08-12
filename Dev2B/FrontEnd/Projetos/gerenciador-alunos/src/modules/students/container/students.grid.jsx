import React, { Component } from 'react';
import Grid from '../components/grid.component';
import api from '../services';

class Students extends Component {
  constructor(props) {
    super(props);
    this.state = { students: [] };
  }

  componentDidMount() {
    this.getStudents();
  }

  async getStudents() {
    const { data } = await api.get('students');
    this.setState({ students: data });
  }

  render() {
    return (
      <>
        <Grid students={this.state.students} />
      </>
    );
  }
}

export default Students;
