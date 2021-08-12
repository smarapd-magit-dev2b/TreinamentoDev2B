import { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import { Badge, Button } from 'react-bootstrap';

import { deck } from '~/services/api';
import useVerifyLogin from '~/hooks/useVerifyLogin';
import useLogout from '~/hooks/useLogout';

export default function Poker(props) {
  const [hand, setHand] = useState([]);
  const [table, setTable] = useState([]);
  const { deckid } = useParams();

  const { user, active } = useVerifyLogin(props);
  
  const getDeck = async id => {
    const response = await deck.get(
      `/api/deck/${id}/draw/?count=7`,
    );

    const cards = response.data;

    setHand([cards.cards[0].image, cards.cards[1].image]);
    setTable([
      cards.cards[2].image,
      cards.cards[3].image,
      cards.cards[4].image,
      cards.cards[5].image,
      cards.cards[6].image,
    ]);
  };

  useEffect(() => {
    getDeck(deckid);
  }, [deckid]);

  const Logout = () => useLogout(props);

  return (
    <>
      <Button onClick={() => Logout()} variant="danger">Sair</Button>
      <h1>Poker</h1>
      <h2>{user}</h2>
      { active
        ? (<Badge bg="success">Ativo</Badge>)
        : (<Badge bg="danger">Inativo</Badge>)
      }
      <h2>Mao</h2>
      {hand.map((card, index) => {
        return <img src={card} alt="Carta" key={index} />;
      })}
      <h2>Mesa</h2>
      {table.map((card, index) => {
        return <img src={card} alt="Carta" key={index} />;
      })}
    </>
  );
}