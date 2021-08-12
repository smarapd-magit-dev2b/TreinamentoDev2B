import React, { useEffect, useState } from 'react';
import ButtonMore from '../../components/card';

import {
  Footer,
  Form,
  Header,
  Main,
  Card,
  Button,
  Col,
  Container,
  Row,
  Img,
} from './styles';
import usePokemon from './usePokemon';

export default function Home(prop) {
  const { history } = prop;
  const [localPokemonSprite, setLocalPokemonSprite] = useState();
  const [pokemonName, setPokemonName] = useState();
  const [pokemon, setPokemon] = useState({
    sprites: {
      front_default:
        'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/132.png',
    },
    name: 'ditto',
    types: [{ type: { name: 'normal' } }],
    height: 3,
    weight: 40,
  });

  useEffect(() => {
    localStorage.removeItem('pokemonSprite');
  }, []);

  const handleChange = (e) => {
    setPokemonName(e.target.value);
  };

  async function handleSubmit(e) {
    e.preventDefault();
    const data = await usePokemon(pokemonName);
    if (data) {
      setPokemon(data);
      const { name, sprites } = data;
      setPokemonName(name);
      // eslint-disable-next-line camelcase
      const { front_default } = sprites;
      setLocalPokemonSprite(front_default);
    }
  }

  const goToPokemon = () => history.push(`/pokemon/${pokemonName}`);

  return (
    <Container fluid>
      <Header>
        <Col as="header">
          <Row>
            <Col>
              <Img src="https://assets.pokemon.com/assets/cms2/img/misc/gus/buttons/logo-pokemon-79x45.png" />
            </Col>
          </Row>
        </Col>
      </Header>
      <Main>
        <Col as="main">
          <Card>
            <Card.Img variant="top" src={pokemon.sprites.front_default} />
            <Card.Body>
              <Card.Title>{pokemon.name}</Card.Title>
              <Card.Text>
                Tipo: {pokemon.types[0].type.name} <br />
                Altura: {pokemon.height} <br />
                Peso: {pokemon.weight}
              </Card.Text>
              {localPokemonSprite ? (
                <Card.Footer>
                  <ButtonMore onClick={goToPokemon} />
                </Card.Footer>
              ) : null}
            </Card.Body>
          </Card>
          <Form onSubmit={handleSubmit}>
            <Form.Group>
              <Form.Control
                type="text"
                placeholder="Pokemon"
                onChange={handleChange}
              />
            </Form.Group>
            <Button variant="primary" type="submit">
              Pesquisar
            </Button>
          </Form>
        </Col>
      </Main>
      <Footer>
        <Col as="footer">
          Created by <b>Bill</b>
        </Col>
      </Footer>
    </Container>
  );
}
