# FizzBuzz
FizzBuzz Program

# Problem Statement:

Create a web application in C# that takes in a collection of values. The application should do the following for each value in the collection:

1.	If the value is a multiple of 3 then output the word “Fizz”
2.	If the value is a multiple of 5 then output the word “Buzz”
3.	If the value is divisible by both 3 and 5 then output the word “FizzBuzz”
4.	At the end of the run the program should display each division that was performed. See Sample Output below.

Sample input: 
[1, 3, 5 , , 15, A, 23]

Sample Output:
Divided 1 by 3
Divided 1 by 5
Fizz
Buzz
Invalid Item
FizzBuzz
Invalid Item
Divided 23 by 3
Divided 23 by 5


# Assumptions:
1. This program prints all the divisions that it performs and additionally as a better practise it would be nice to print them in Console rather than recording everything in the Output.
2. Utilized Microsoft .Net Core MVC, C#, jQuery and MS Tests.
3. For Invalid Input - Instead of saying just 'Invalid Item' it is printed as 'Invalid Item A', it make more sense to the user on what its complaining about especially when we're printing a whole lot of Debug information.

