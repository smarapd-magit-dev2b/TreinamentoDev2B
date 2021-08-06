import axios from 'axios';

export const gitHub = axios.create({ baseURL: 'https://api.github.com/' });
export const deck = axios.create({
  baseURL: 'https://deckofcardsapi.com/',
});
