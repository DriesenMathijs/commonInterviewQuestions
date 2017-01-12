
module.exports = fizzbuzz;

function fizzbuzz(num) {
  if (num == undefined) {
    throw new Error('No argument provided');
  }

  if (typeof num !== 'number') {
    throw new Error('Argument must be of type number');
  }

  if (arguments.length > 1) {
    throw new Error('Invalid arguments length');
  }

  var conditions = [
    { value: 3, result: 'fizz' },
    { value: 5, result: 'buzz' }
  ];

  var result = '';

  conditions.forEach(condition => result += num % condition.value === 0 ? condition.result : '');

  return result;
}
