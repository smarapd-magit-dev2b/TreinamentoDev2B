import { Alert as BootstrapAlert } from 'react-bootstrap';
import styled, { keyframes } from 'styled-components';

const down = keyframes`
from{
  transform: translate(-50%, -100%)
}
to{transform: translate(-50%, 0)}`;

export const Alert = styled(BootstrapAlert)`
  position: fixed;
  left: 50%;
  transform: translate(-50%);

  animation-name: ${down};
  animation-duration: 300ms;
`;
