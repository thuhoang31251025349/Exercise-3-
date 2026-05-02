//.1 ( +, -,*, x,/ )
int a = 10;
int b = 5;
if (operator == '+') Console.WriteLine($"{a} + {b} = {a + b}");
else if (operator == '-') Console.WriteLine($"{a} - {b} = {a - b}");
else if (operator == '*') Console.WriteLine($"{a} * {b} = {a * b}");
else if (operator == '/') Console.WriteLine(b != 0 ? $"{a} / {b} = {a / b}" : "Không thể chia cho 0");

//2.
Console.WriteLine("y \t x = y² + 2y + 1");
for (int y = -5; y <= 5; y++)
{
    int x = y * y + 2 * y + 1;
    Console.WriteLine($"{y} \t {x}");
}
//3.
double d = double.Parse( Console.ReadLine());
int h = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int s = int.Parse(Console.ReadLine());
double t = h + m/60.0 + s / 3600.0;
Console.WriteLine(d/t);
Console.WriteLine( d/t*0/621371);
//4.
double r = double.Parse(Console.ReadLine ());
Console.WriteLine( 4*Math.PI*r*r);
Console.WriteLine(4.0/3*Math.PI*r*r*r);
//5.
