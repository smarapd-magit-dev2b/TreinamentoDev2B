import { BrowserRouter } from 'react-router-dom';

import Routes from './routes';

import './styles/global.scss';
import 'bootstrap/dist/css/bootstrap.min.css'

export default function App() {
  return (
    <BrowserRouter>
      <Routes />
    </BrowserRouter>
  )
}
