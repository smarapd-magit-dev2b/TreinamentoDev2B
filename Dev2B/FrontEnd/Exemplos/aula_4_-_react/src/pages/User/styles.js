import styled from 'styled-components';

import Colors from '@styles/colors';

export const Container = styled.div`
  display: flex;
`;

export const Content = styled.div`
  display: flex;
  flex: 1;
  height: 100vh;
  background-color: ${Colors.primary};
  padding: 10px;

  align-items: center;
  justify-content: center;

  position: relative;

  button:first-child {
    position: absolute;
    top: 10px;
    left: 10px;
  }

  .card {
    border-top-left-radius: 150px;
    border-top-right-radius: 150px;

    img {
      border-top-left-radius: 150px;
      border-top-right-radius: 150px;
    }
  }
`;