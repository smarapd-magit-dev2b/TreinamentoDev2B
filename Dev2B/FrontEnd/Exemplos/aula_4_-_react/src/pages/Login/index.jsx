import { useState, useEffect } from 'react';
import { Form, Button } from 'react-bootstrap';

import { deck } from '~/services/api';

export default function Login(prop) {
  const [nome, setNome] = useState();
  const [senha, setSenha] = useState();
  const [deckId, setDeckId] = useState();
  const { history } = prop;

  useEffect(() => {
    async function getDeck() {
      const response = await deck.get('api/deck/new/shuffle/?deck_count=1');
  
      if (response.status === 200) setDeckId(response.data.deck_id)
    }
  
    getDeck();
  }, [])


  function handleLogin(event) {
    event.preventDefault();

    if (nome == "Erick" && senha == "123") {
      localStorage.setItem('pokerUser', nome);
      localStorage.setItem('active', true);

      history.push(`/poker/${deckId}`);
    } else {
      localStorage.removeItem('pokerUser');
      localStorage.removeItem('active');

      alert('Verifique Usuário e Senha');
    }
  }

  const setValues = (values, set) => set(values.target.value)

  return (
    <>
      <Form>
        <Form.Group className="mb-3" controlId="formBasicEmail">
          <Form.Label>Nome</Form.Label>
          <Form.Control type="text" placeholder="Nome" onChange={value => setValues(value, setNome)} />
        </Form.Group>

        <Form.Group className="mb-3" controlId="formBasicPassword">
          <Form.Label>Senha</Form.Label>
          <Form.Control type="password" placeholder="Senha" onChange={value => setValues(value, setSenha)} />
        </Form.Group>
        <Button onClick={e => handleLogin(e)} variant="primary" type="button">
          Submit
        </Button>
      </Form>
    </>
  )
}

