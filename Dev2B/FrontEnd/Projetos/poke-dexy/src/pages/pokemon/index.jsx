import React, { Component } from 'react';
import PropTypes from 'prop-types';
import { Img, CloseButton } from './styles';

class Pokemon extends Component {
  constructor(props) {
    super(props);
    this.state = { pokemonSprite: '' };
  }

  componentDidMount() {
    this.setState({ pokemonSprite: localStorage.getItem('pokemonSprite') });
  }

  render() {
    const { pokemonSprite } = this.state;
    const { history } = this.props;
    return (
      <>
        <CloseButton onClick={() => history.push('/')} />
        <Img src={pokemonSprite} />
      </>
    );
  }
}

Pokemon.propTypes = {
  history: PropTypes.object.isRequired,
};

export default Pokemon;
