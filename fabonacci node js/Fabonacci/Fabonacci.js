

var i;
var fibonacciArray = []; // Initialize array!
var createFibonacci=function(n){
fibonacciArray[0] = 0;
fibonacciArray[1] = 1;
for (i = 2; i < n; i++) {
  // fibonacci number = previous + one before previous
  fibonacciArray[i] = fibonacciArray[i - 2] + fibonacciArray[i - 1];
}
return fibonacciArray;
}
console.log(createFibonacci(8));

//run the code -> node fabonacci.js