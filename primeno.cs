using System;
class primeChecker{
public static bool isPrime(int n){
if (n <= 1) return false;

for (int i =2; i*i <= n ; i++){
if( n % i == 0) return false;

}
return true;

}

public static void Main(String [] args){
int n = 11;
if (isPrime(n)) Console.WriteLine("it is a prime no");
else Console.WriteLine("it is not a prime no");


}

}