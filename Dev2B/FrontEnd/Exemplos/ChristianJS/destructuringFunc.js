function rand({ min = 0, max = 100 }) {
  const valor = Math.random() * (max - min) + min;
  return Math.floor(valor);
}

const obj = { max: 5, min: 1 };
console.log(rand(obj));
