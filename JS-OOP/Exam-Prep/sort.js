var items = [
  { name: 'Edward', value: 21 },
  { name: 'Sharpe', value: 37 },
  { name: 'And', value: 45 },
  { name: 'And', value: 11 },
  { name: 'The', value: -12 },
  { name: 'Magnetic',value: 11 },
  { name: 'Zeros', value: 37 },
  { name: 'Magnetic',value: 993 },
  { name: 'Zeros', value: 2 },
  { name: 'Zeros', value: 3 },
  { name: 'Zeros', value: -22 },
];
items.sort(function (a, b) {
  if (a.name > b.name) {
    return 1;
  }
  if (a.name < b.name) {
    return -1;
  }
  if (a.name === b.name)
  {
     return a.value - b.value;
  }
});

for( prop in items)
{
   console.log('prop: ' + prop + ' items[prop] NAME: ' + items[prop].name + ' items[prop] VALUE: ' + items[prop].value);
}