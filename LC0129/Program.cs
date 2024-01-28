// MIS 3013 001
// Jan 29, 2024
// Alexandra Camarena
// 113568154

// string: complex datatype
string str1;
str1 = "This is a string";// "" is the syntax to define a string

Console.WriteLine(str1);

// console.readline

string str2;
str2 =Console.ReadLine();// ReadLine is a function
// ReadLine() is a function call
// the final product is a string

Console.WriteLine("The user input is: ");
Console.WriteLine(str2);

//
string str3;
str3 = "20";// str3 is a string, not an integer

int age1;
age1 = Convert.ToInt32(str3);//

Console.WriteLine(age1 + 2);

//
string str4;
str4 = Console.ReadLine();
int age2;
age2 = Convert.ToInt32(str4);
Console.WriteLine(age2 + 10);

