var fib = function (index) {
    var seq = [0, 1];
    for (var i = 2; i < index; i++) {
        seq[i] = seq[i - 2] + seq[i - 1];
    }
    return seq;
};

console.log(fib(5));