const pilotos = ["Vettel", "Alonso", "Raikkonen", "Massa"];

pilotos.pop();
console.log(pilotos);

pilotos.push("Rubinho");
console.log(pilotos);

pilotos.shift();
console.log(pilotos);

pilotos.unshift("Halmilton");
console.log(pilotos);

pilotos.splice(2, 0, "Bottas", "Massa");
console.log(pilotos);

pilotos.splice(3, 1);
console.log(pilotos);
