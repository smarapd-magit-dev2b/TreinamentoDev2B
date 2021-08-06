import React, { useState } from 'react';
import { gitHub } from '../../services/services';

export default function User() {
  const [user, setUser] = useState({ id: 5, name: 'Lucas' });
  async function getUser() {
    const response = await gitHub.get('/users/ludcoll/');

    setUser(response.data.name);
  }

  getUser();

  return <h1>{user.name}</h1>;
}
