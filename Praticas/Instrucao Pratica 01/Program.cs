#region Question Number Two

// Numeric Dates :
int min = int.MinValue;
int max = int.MaxValue;
Console.WriteLine(min);
Console.WriteLine(max);


double minValueDouble = double.MinValue;
double maxValueDouble = double.MaxValue;
Console.WriteLine($"Double Min Value: {minValueDouble}");
Console.WriteLine($"Double Max Value: {maxValueDouble}");

float minValueFloat = float.MinValue;
float maxValueFloat = float.MaxValue;
Console.WriteLine($"Float Min Value: {minValueFloat}");
Console.WriteLine($"Float Max Value: {maxValueFloat}");

decimal minValueDecimal = decimal.MinValue;
decimal maxValueDecimal = decimal.MaxValue;
Console.WriteLine($"Decimal Min Value: {minValueDecimal}");
Console.WriteLine($"Decimal Max Value: {maxValueDecimal}");

// You can perform operations between int, double and float without the need for cast:
int integer = 10;
double _double = 2.5d;
float _float = 4.9f;

Console.WriteLine(integer + _double + _float);
// But to do this with the decimal, which has greater precision, it is necessary to perform Parse:
decimal _decimal = 2.5m;
// double result = _double * _decimal; // It will generate an error, the correct one would be:
double result = _double * Convert.ToDouble(_decimal);
Console.WriteLine(result); // 10.0

#endregion

#region Question Number Three

double number = 2.5d;
int number2 = (int)number;
Console.WriteLine(number2); // In this case the part after the decimal point is lost.

#endregion

#region Question Number Four

int x = 10;
int y = 3;

Console.WriteLine($"Sum of {x} + {y} = {x + y}");
Console.WriteLine($"Subtraction from {x} - {y} = {x - y}");
Console.WriteLine($"Multiplication of {x} * {y} = {x * y}");
Console.WriteLine($"Division of {x} / {y} = {x / y}");
Console.WriteLine($"Rest of entire division is {x} % {y} = {x % y}");   

#endregion

#region Question Number Five

int a = 5;
int b = 8;

Console.WriteLine($"{a} is greater than {b} ? {a > b}");

#endregion

#region Question Number Six

string str1 = "Hello";
string str2 = "World";

Console.WriteLine($"{str1} is equal to {str2} ? {str1 == str2}");

#endregion

#region Question Number Seven

bool condiction1 = true;
bool condiction2 = false;

Console.WriteLine($"{condiction1} is true ? {condiction1 == true}");
Console.WriteLine($"{condiction2} is true ? {condiction2 == true}");

#endregion

#region Question Number Eight

int num1 = 7;
int num2 = 3;
int num3 = 10;

Console.WriteLine($"{num1} is greater than {num2} ? {num1 > num2}");
Console.WriteLine($"{num3} is equal to {num1} + {num2} ? {num3 == (num1 + num2)}");
Console.WriteLine($"{num1} is greater than {num2} and {num3} is equal to {num1 + num2} ? {num1 > num2 && (num3 == (num1 + num2))}");

#endregion