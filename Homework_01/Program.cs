#region Variables 
double x;
double y;
double a;
double b;
double sum;
#endregion


// ******* Exercise 1 ******* 
#region Exercise 1

// 4 
Console.WriteLine("Exercise : " + 1);
Console.WriteLine();
Console.WriteLine("Problem : " + 4);

Console.Write("Set the X : ");
double.TryParse(Console.ReadLine(), out x);
Console.Write("Set the Y : ");
double.TryParse(Console.ReadLine(), out y);

sum = Math.Log(Math.Pow(Math.E, x) + 1, Math.E) + (Math.Pow(x, 2) + 4) * 1/3;
Console.WriteLine("The sum is : " + sum);

// 8
Console.WriteLine();
Console.WriteLine("Problem : " + 8);

Console.Write("Set the X : "); 
double.TryParse(Console.ReadLine(), out x);
Console.Write("Set the Y : ");
double.TryParse(Console.ReadLine(), out y);

sum = ((Math.Pow(x, 2) + (Math.Pow(y, 2) + 4) * 1 / 3) * 1 / 4) + Math.Pow(Math.Abs(x) + Math.Abs(y), 10);

Console.WriteLine("The sum is : " + sum);

#endregion 



// ******* Exercise 2 ******* 
#region Exercise 2
Console.WriteLine();

// 11
Console.WriteLine("Exercise : " + 2);
Console.WriteLine();
Console.WriteLine("Problem : " + 11);

Console.Write("Set the A : ");
double.TryParse(Console.ReadLine(), out a);
Console.Write("Set the B : ");
double.TryParse(Console.ReadLine(), out b);
Console.Write("Set the X : ");
double.TryParse(Console.ReadLine(), out x);

if (Math.Sqrt(a) + Math.Sqrt(y) > 5)
{
    y = Math.Pow(3 * Math.E, a - x) + Math.Log(Math.Sqrt(a) + Math.Sqrt(b) + 5, 3);
}
else if (Math.Sqrt(a) + Math.Sqrt(y) < 1)
{
    y = Math.Pow(Math.Tan(a + b), 4);
}
else
{
    y = -3;
}

Console.WriteLine("Y is : " + y);


// 12
Console.WriteLine();
Console.WriteLine("Problem : " + 12);


Console.Write("Set the A : ");
double.TryParse(Console.ReadLine(), out a);
Console.Write("Set the X : ");
double.TryParse(Console.ReadLine(), out x);

if (x >= -5 && x <= 5)
{
    y = Math.Pow(1 + Math.Pow(a, 2), 6);
}
else if (x > 5)
{
    y = Math.Cos(Math.Pow(Math.Log(Math.Abs(x) + Math.Pow(x, 8), Math.E), 2));
}
else
{
    y = a;
}

Console.WriteLine("Y is : " + y);

#endregion 



// ******* Exercise 3 ******* 
#region Exercise 3
Console.WriteLine();

// 74
Console.WriteLine("Exercise : " + 3);
Console.WriteLine("Problem : " + 74);

Console.Write("Set the X : ");
double.TryParse(Console.ReadLine(), out x);

for (double dx = -3.8; dx <= 5.4; dx += 0.3)
{
    y = Math.Pow(2, x + 4);
    Console.WriteLine(y);
}



// 77
Console.WriteLine("Problem : " + 77);
Console.Write("Set the X : ");
double.TryParse(Console.ReadLine(), out x);

for (int dx = -8; dx <= 8; dx+=3)
{
    if (dx > 2)
        y = Math.Pow(x, 2) + Math.Pow(x, 8);
    else
        y = 0;

    Console.WriteLine(y);
}
#endregion


// ******* Exercise 4 ******* 
#region Exercise 4
Console.WriteLine();

// 111 
Console.WriteLine("Exercise : " + 4);
Console.WriteLine("Problem : " + 111);

Console.Write("Set the X : ");
double.TryParse(Console.ReadLine(), out x);

for (int n = 0; n <= 5; n++)
{
    sum = Math.Pow(x, 4 * n + 1) / (4 * n + 1);
    Console.WriteLine($"In case of 'n' = {n}. sum is : {sum}");
}


// 118
Console.WriteLine("Problem : " + 118);

Console.Write("Set the X : ");
double.TryParse(Console.ReadLine(), out x);

for (int n = 0; n <= 5; n++)
{
    sum = Math.Pow(Math.Abs(2 * x + n), n) / ((n + 1) * (n + 2));
    Console.WriteLine($"In case of 'n' = {n}. sum is : {sum}");
}
#endregion 




