import styled from 'styled-components';

import Colors from '@styles/colors';

export const Container = styled.div`
  height: 100vh;
  width: 100vw;
`;

export const Head = styled.div`
  display: flex;
  flex: 1;
  height: 15vh;
  background-color: ${Colors.primary};
  justify-content: center;
  align-items: center;

  h1 {
    color: ${Colors.AmandaBlue};
  }
`;

export const Main = styled.main`
  display: flex;
  flex: 1;
  height: 85vh;
  background-color: ${Colors.claret};

  align-items: center;
  justify-content: space-evenly;

  button {
    padding: 15px 30px;
    background-color: ${Colors.primary};
    border: none;
    border-radius: 10px;
  }
`;
