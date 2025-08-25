// 1. Check whether a number is prime or not
function isPrime(num) {
    if (num <= 1) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) return false;
    }
    return true;
}

// 2. Find sum of Fibonacci series up to n terms
function fibonacciSum(n) {
    let a = 0, b = 1, sum = 0;
    for (let i = 1; i <= n; i++) {
        sum += a;
        let temp = a + b;
        a = b;
        b = temp;
    }
    return sum;
}

// 3. Count even, odd, and zero in an array
function countEvenOddZero(arr) {
    let even = 0, odd = 0, zero = 0;

    for (let num of arr) {
        if (num === 0) {
            zero++;
        } else if (num % 2 === 0) {
            even++;
        } else {
            odd++;
        }
    }

    return { even, odd, zero };
}



console.log("Prime Check:");
let number = 29;
console.log(number + (isPrime(number) ? " is Prime" : " is Not Prime"));

console.log("\nFibonacci Sum:");
let n = 6;
console.log("Sum of Fibonacci series up to " + n + " terms: " + fibonacciSum(n));

console.log("\nEven, Odd, Zero Count:");
let numbers = [0, 2, 5, 8, 0, 7, 4, 3];
let result = countEvenOddZero(numbers);
console.log("Even:", result.even, "Odd:", result.odd, "Zero:", result.zero);
