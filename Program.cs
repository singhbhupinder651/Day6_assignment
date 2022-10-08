// See https://aka.ms/new-console-template for more information
using Day6LogicalPrograms;

Console.WriteLine("Welcome to logical program");

FibonacciSeriesProblem ran1 = new FibonacciSeriesProblem();
ran1.FibonacciSeries();

PerfectNumberProblem ran2 = new PerfectNumberProblem();
ran2.PerfectNumber();

PrimeNumberProblem ran4 = new PrimeNumberProblem();
ran4.PrimeNumber();

ReverseNumberProblem ran5 = new ReverseNumberProblem();
ran5.ReverseNumber();

Console.Write("How many numbers you wants to generate: ");
int N = Convert.ToInt32(Console.ReadLine());
CouponNumbersProblem.CouponNumber(N);