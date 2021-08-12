import pokeDex from '../../services';

async function usePokemon(name) {
  try {
    const { data } = await pokeDex.get(`pokemon/${name}`);
    localStorage.setItem('pokemonSprite', data.sprites.front_default);
    return data;
  } catch {
    // eslint-disable-next-line no-alert
    alert(`${name} não existe ou está em falta no banco`);
    localStorage.removeItem('pokemonSprite');
    return null;
  }
}

export default usePokemon;
