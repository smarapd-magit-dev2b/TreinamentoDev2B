const axios = require('axios').default;

const pokeDex = axios.create({ baseURL: 'https://pokeapi.co/api/v2/' });

export default pokeDex;
