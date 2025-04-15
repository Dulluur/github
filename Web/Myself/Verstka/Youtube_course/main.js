const users = [
  {
    name: "Du",
    age: 28,
  },
  {
    name: "Ostap",
    age: 26,
  },
  {
    name: "Dima",
    age: 29,
  },
];

// console.log(
//     users.filter((user) => {
//         return user.name === "Du" || user.age < 45
//     })
// )

const filterUsers = users.filter(({name, age}) =>{
    return name === "Du" || age < 18
})

console.log(filterUsers)