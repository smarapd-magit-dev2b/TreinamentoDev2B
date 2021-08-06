import React from 'react';
import { useHistory } from 'react-router-dom';
import { Button } from 'react-bootstrap';
import { Main, Header } from './styles';

export default function Home() {
  const history = useHistory();

  function pushPoker() {
    history.push(`/login`);
  }
  function pushUser() {
    history.push('/user');
  }

  return (
    <>
      <Header>
        <h1>Dev2B</h1>
      </Header>
      <Main>
        <Button onClick={pushUser}>Usuário</Button> <br /> <br />
        <Button onClick={pushPoker}>Poker</Button>
      </Main>
    </>
  );
}
