function isPalindrome(str) {
    return str.split('').reverse().join('') === str;
}

/*
wow123454321

wow12345432
ow123454321

wow1234543
ow12345432
w123454321

wow123454
ow1234543
w12345432
123454321 // gevonden, break :)
*/
function longestPalindrome(str) {
    var palindrome = '';

    for (var i = str.length; i > 0; i--) {
        for (var j = 0; j < str.length - i; j++) {
            // only check current length
            var strToCheck = str.substring(j, i + j);
            // or
            // strToCheck = str.substr(j, i);

            if (isPalindrome(strToCheck)) {
                palindrome = strToCheck;
            }
        }

        if (palindrome) {
            break;
        }
    }

    return palindrome;
}

console.log(longestPalindrome('wowjezuslegovogel01234543210'));