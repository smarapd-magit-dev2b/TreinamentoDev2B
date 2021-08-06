import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import { Badge } from 'react-bootstrap';
import { deck } from '../../services/services';
import useAuth from '../../hooks/useAuth';

export default function Poker(props) {
  const [hand, setHand] = useState([]);
  const [table, setTable] = useState([]);
  const { deckid } = useParams();
  const { user, active } = useAuth(props);

  useEffect(() => {
    async function getDeck(id) {
      const response = await deck.get(`/api/deck/${id}/draw/?count=7`);
      const { data } = response;

      setHand([data.cards[0].image, data.cards[1].image]);

      setTable([
        data.cards[2].image,
        data.cards[3].image,
        data.cards[4].image,
        data.cards[5].image,
        data.cards[6].image,
      ]);
    }
    getDeck(deckid);
  }, [deckid]);

  return (
    <>
      <h1>Poker</h1>
      <h3>
        {user}{' '}
        {active ? (
          <Badge bg='primary'>Ativo</Badge>
        ) : (
          <Badge bg='danger'>Inativo</Badge>
        )}
      </h3>
      <h2>Mão</h2>
      {hand.map((card) => (
        <img src={card} alt='cartas' />
      ))}
      <h2>Mesa</h2>
      {table.map((card) => (
        <img src={card} alt='carta' />
      ))}
    </>
  );
}
