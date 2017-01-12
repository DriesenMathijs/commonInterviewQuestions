/**
 * `npm install jest-cli -g`
 * jest fizzbuzz.test.js
 */

var fizzbuzz = require('./fizzbuzz.js');


describe('fizzbuzz', function () {

  it('should throw an error when no argument provided', function () {
    expect(() => fizzbuzz()).toThrow(new Error('No argument provided'));
  });

  it('should throw an error when argument is not of type number', function () {
    expect(() => fizzbuzz('input')).toThrow(new Error('Argument must be of type number'));
  });

  it('should throw an error when given two or more arguments', function () {
    expect(() => fizzbuzz(1, 2)).toThrow(new Error('Invalid arguments length'));
    expect(() => fizzbuzz(1, 2, 3)).toThrow(new Error('Invalid arguments length'));
  });

  it('should return `fizz` if number is divisible by three', function () {
    let [first, second, third] = [fizzbuzz(3), fizzbuzz(6), fizzbuzz(36)];

    expect(first).toBe('fizz');
    expect(second).toBe('fizz');
    expect(third).toBe('fizz');
  });

  it('should return `buzz` if number is divisible by five', function () {
    let [first, second, third] = [fizzbuzz(5), fizzbuzz(10), fizzbuzz(100)];

    expect(first).toBe('buzz');
    expect(second).toBe('buzz');
    expect(third).toBe('buzz');
  });

  it('should return `fizzbuzz` if number is divisible by three and five', function () {
    let [first, second, third] = [fizzbuzz(3 * 2 * 5), fizzbuzz(3 * 12 * 5), fizzbuzz(3 * 124 * 5)];

    expect(first).toBe('fizzbuzz');
    expect(second).toBe('fizzbuzz');
    expect(third).toBe('fizzbuzz');
  });
});
