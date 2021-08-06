import React from 'react';
import { Container } from 'react-bootstrap';
import PropTypes from 'prop-types';

export default function Main({ children }) {
  return (
    <Container>
      <main>{children}</main>
    </Container>
  );
}

Main.propTypes = { children: PropTypes.element.isRequired };
