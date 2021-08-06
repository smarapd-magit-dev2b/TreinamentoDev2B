import React from 'react';
import PropTypes from 'prop-types';

export default function Button({ onClick, children }) {
  return (
    <button type="button" onClick={onClick}>
      {children}
    </button>
  );
}

Button.propTypes = {
  onClick: PropTypes.string.isRequired,
  children: PropTypes.node.isRequired,
};
