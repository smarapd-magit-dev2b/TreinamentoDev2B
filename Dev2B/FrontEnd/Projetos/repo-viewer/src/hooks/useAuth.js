import { useState, useEffect } from 'react';

export default function useAuth(props) {
  const [user, setUser] = useState();
  const [active, setActive] = useState();
  const { history } = props;

  useEffect(() => {
    const userTemp = localStorage.getItem('user');

    if (!userTemp) history.push('/login');

    setUser(userTemp);
    setActive(localStorage.getItem('active'));
  });
  return { user, active };
}
