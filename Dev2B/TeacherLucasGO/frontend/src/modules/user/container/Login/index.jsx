import React from "react";
import { Container, Row, Form, Button } from "./styles";

export default function Login() {
  return (
    <Container>
      <Row>
        <Form>
          <Form.Group>
            <Form.Label>Nome de usuário</Form.Label>
            <Form.Control type="text" placeholder="Usuário..." />
          </Form.Group>
          <Form.Group>
            <Form.Label>Senha</Form.Label>
            <Form.Control type="password" placeholder="Senha..." />
          </Form.Group>
          <Button variant="primary" type="submit">
            Logar
          </Button>
        </Form>
      </Row>
    </Container>
  );
}
