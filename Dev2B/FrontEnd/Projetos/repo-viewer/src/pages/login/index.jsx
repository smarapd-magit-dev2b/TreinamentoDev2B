import { Form, Button } from 'react-bootstrap';
import { useHistory } from 'react-router-dom';
import React, { useState, useEffect } from 'react';
import { deck } from '../../services/services';
import Alert from '../../components/alert/Alert';

export default function Login() {
  const [name, setName] = useState();
  const [pass, setPass] = useState();
  const [deckId, setDeckId] = useState();
  const history = useHistory();

  useEffect(() => {
    async function getDeck() {
      const response = await deck.get('api/deck/new/shuffle/?deck_count=1');

      if (response.status === 200) setDeckId(response.data.deck_id);
    }
    getDeck();
  });

  function handleLogin(e) {
    e.preventDefault();

    if (name === 'Lucas' && pass === '123') {
      localStorage.setItem('user', name);
      localStorage.setItem('active', true);
      history.push(`/poker/${deckId}`);
    } else {
      localStorage.removeItem('user');
      localStorage.removeItem('active');

      localStorage.setItem('alert', 'Verifique Usuário e Senha');
    }
  }

  const setValues = (value, state) => state(value.target.value);

  return (
    <main>
      <Alert />
      <Form>
        <Form.Group className='mb-3' controlId='formBasicEmail'>
          <Form.Label>Nome</Form.Label>
          <Form.Control
            type='text'
            placeholder='Nome'
            onChange={(value) => setValues(value, setName)}
          />
        </Form.Group>

        <Form.Group className='mb-3' controlId='formBasicPassword'>
          <Form.Label>Senha</Form.Label>
          <Form.Control
            type='password'
            placeholder='Senha'
            onChange={(value) => setValues(value, setPass)}
          />
        </Form.Group>
        <Button type='button' onClick={(e) => handleLogin(e)} variant='primary'>
          Submit
        </Button>
      </Form>
    </main>
  );
}

// useState() -> retorna [variável, função]

// useEffect(() => {}, [])
