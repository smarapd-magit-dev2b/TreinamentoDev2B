import 'bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter } from 'react-router-dom';
import React from 'react';
import Routes from './routes';

export default function App() {
  return (
    <BrowserRouter>
      <Routes />
    </BrowserRouter>
  );
}
