import { Image, CloseButton as BootsCloseButton } from 'react-bootstrap';
import styled from 'styled-components';

export const Img = styled(Image)`
  height: 100%;
  image-rendering: pixelated;
  image-rendering: -moz-crisp-edges;
  image-rendering: crisp-edges;
`;

export const CloseButton = styled(BootsCloseButton)`
  position: absolute;
  margin-top: 1em;
  margin-left: 1em;
  top: 0px;
  left: 0px;
`;
