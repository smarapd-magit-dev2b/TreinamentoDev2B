import { useState, useEffect } from 'react';

export default function useVerifyLogin(props) {
  const [user, setUser] = useState();
  const [active, setActive] = useState(false);
  const { history } = props;

  useEffect(() => {
    let usuario = localStorage.getItem("pokerUser")

    if(!usuario) history.push('/login');
    
    setUser(usuario);
    setActive(localStorage.getItem("active"));
  }, [])

  return { user, active };
}

