import React, { useEffect, useState } from 'react';
import { Alert as StyledAlert } from './styles';

export default function Alert() {
  const [message, setMessage] = useState();

  useEffect(() => {
    localStorage.removeItem('alert');
  }, []);

  useEffect(() => {
    const alert = localStorage.getItem('alert');
    setMessage(alert);
  }, [localStorage.getItem('alert')]);

  if (message) {
    return (
      <StyledAlert
        variant='warning'
        onClose={() => {
          localStorage.removeItem('alert');
        }}
        dismissible
      >
        {message}
      </StyledAlert>
    );
  }
  return <></>;
}
