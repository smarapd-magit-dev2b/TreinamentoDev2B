import React from 'react';
import PropTypes from 'prop-types';
import Button from './style';

export default function ButtonMore({ onClick }) {
  return (
    <Button type="button" onClick={onClick}>
      Zoom
    </Button>
  );
}

ButtonMore.propTypes = {
  onClick: PropTypes.func.isRequired,
};
