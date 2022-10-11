Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Что бы произвести сложение введите 0; вычитание 1; умножение 2; деление 3");
int g = Convert.ToInt32(Console.ReadLine());
int d = a + b;
int f = a - b;
int e = a * b;
int j = a / b;


if (g == 0)
{
    Console.Write("= ");
    Console.WriteLine(d);
}    
    
if (g == 1)
{   
    Console.Write("= ");
    Console.WriteLine(f);
}   

if (g == 2)
{  
    Console.Write("= ");
    Console.WriteLine(e);
}  

if (g == 3)
{  
    Console.Write("= ");
    Console.WriteLine(j);
}  