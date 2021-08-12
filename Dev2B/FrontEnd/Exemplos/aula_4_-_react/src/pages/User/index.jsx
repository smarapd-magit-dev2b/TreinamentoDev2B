
import { useState, useEffect } from 'react';
import { github } from '~/services/api';
import { CloseButton, Card } from 'react-bootstrap';

import { Container, Content } from './styles';

export default function User(props) {
  const [user, setUser] = useState();

  const getUser = async () => {
    const response = await github.get('/users/vieiraerick')

    setUser(response.data)
  }

  useEffect(() => {
    getUser();
  }, [])

  function goBack() {
    props.history.goBack();
  }

  return (
    <Container>
      <Content>
        <CloseButton variant="white" onClick={() => goBack()} />

        <Card style={{ width: 300 }}>
          <Card.Img variant="top" src={user?.avatar_url} />
          <Card.Body>
            <Card.Title>{user?.name}</Card.Title>
            <Card.Text>Repositórios: {user?.public_repos}</Card.Text>
            <Card.Text>Seguidores: {user?.followers}</Card.Text>

          </Card.Body>
        </Card>
      </Content>
    </Container>
  )
}