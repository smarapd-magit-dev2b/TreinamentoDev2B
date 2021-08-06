import { useState } from 'react';
import './App.css';
import Botao from './components/Button';

function App() {
  const [nome, setNome] = useState('Insira um nome');
  function changeName(name = '') {
    setNome(name);
  }
  return (
    <>
      <h1>Dev2B</h1>
      <h2>{nome}</h2>

      <Botao onClick={() => changeName('roberto')}>Aloooo</Botao>
    </>
  );
}

export default App;
