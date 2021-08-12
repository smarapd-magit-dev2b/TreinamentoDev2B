import {
  Form as BootsForm,
  Card as BootsCard,
  Button as BootsButton,
  Row as BootsRow,
  Col as BootsCol,
  Container as BootsContainer,
  Image,
} from 'react-bootstrap';
import styled from 'styled-components';

// Principais Layouts
export const Container = styled(BootsContainer)`
  height: 100%;
  display: flex;
  flex-direction: column;
  align-items: center;
`;
export const Header = styled(BootsRow)``;
export const Main = styled(BootsRow)`
  flex-grow: 1;
  main {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }
`;
export const Footer = styled(BootsRow)``;

// Layouts Secundários
export const Row = styled(BootsRow)``;
export const Col = styled(BootsCol)``;

// Principáis Componentes
export const Form = styled(BootsForm)`
  display: flex;
  flex-direction: column;
  align-items: center;

  div {
    margin-bottom: 1rem;
  }
`;
export const Card = styled(BootsCard)`
  margin: 1rem;
  align-items: center;
  Img {
    width: 96px;
  }
`;
export const Button = styled(BootsButton)``;
export const Img = styled(Image)``;
