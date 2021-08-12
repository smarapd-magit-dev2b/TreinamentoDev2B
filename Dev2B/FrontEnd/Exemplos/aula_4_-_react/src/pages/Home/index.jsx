import { useState, useEffect } from 'react';
import { Button } from 'react-bootstrap';

import { deck } from '~/services/api';

import { Container, Main, Head } from './styles';

export default function Home(prop) {
  const [deckId, setDeckId] = useState();
  const { history } = prop;

  useEffect(() => {
    async function getDeck() {
      const response = await deck.get('api/deck/new/shuffle/?deck_count=1');
  
      if (response.status === 200) setDeckId(response.data.deck_id)
    }
  
    getDeck();
  }, [])

  function redirect(path) {
    history.push(path)
  }

  return (
    <Container>
      <Head>
        <h1>Escolha seu destino</h1>
      </Head>

      <Main>
        <Button onClick={() => redirect("/user")}>Usuário Github</Button>
        <Button onClick={() => redirect(`/login`)}>Poker</Button>
      </Main>
    </Container>
  )
}