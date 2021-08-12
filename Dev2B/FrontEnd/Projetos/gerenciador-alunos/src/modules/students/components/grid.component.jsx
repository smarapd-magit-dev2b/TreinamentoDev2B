import React, { Component } from 'react';
import PropTypes from 'prop-types';

class GridComponents extends Component {
  render() {
    return (
      <>
        <h1>Grid</h1>
        {this.props.students.map((student) => (
          <>
            <h1>Id: {student.id}</h1>
            <h2>Nome: {student.name}</h2>
            <h3>Nota 1: {student.note1}</h3>
            <h3>Nota 2: {student.note2}</h3>
          </>
        ))}
      </>
    );
  }
}

GridComponents.propTypes = {
  students: PropTypes.any.isRequired,
};
export default GridComponents;
