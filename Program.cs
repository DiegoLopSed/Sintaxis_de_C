// See https://aka.ms/new-console-template for more information
int a = 7;
int b = 2;
double d = 2;
int c;
double f;
Console.WriteLine("Operadores aritméticos-------------------------------");
c= a + b; //Suma
Console.WriteLine("a+b="+ c.ToString());
c = a - b; //Resta
Console.WriteLine("a-b="+ c.ToString());
c = a * b;//Multiplicación
Console.WriteLine("a*b="+ c.ToString());
c = a / b; //División entre dos enteros
Console.WriteLine("a/b="+ c.ToString());
f = a / d; //División que contiene un valor de punto flotante
Console.WriteLine("a/d="+ f.ToString());
c = Convert.ToInt16(Math.Pow(a,b)); //Potencia
Console.WriteLine("a^b="+ c.ToString());
c = a % b; //Residuo
Console.WriteLine("a%b="+ c.ToString());

Console.WriteLine("Operadores lógicos-------------------------------");
bool p = false;
bool q = false;
bool r = true;
bool s = true;
bool valorBooleano;

valorBooleano = p && q;
Console.WriteLine("p y q:" + valorBooleano.ToString());
valorBooleano = r && s;
Console.WriteLine("r y s:" + valorBooleano.ToString());
valorBooleano = p || q;
Console.WriteLine("p o q:" + valorBooleano.ToString());
valorBooleano = p || r;
Console.WriteLine("p o r:" + valorBooleano.ToString());
valorBooleano = !p;
Console.WriteLine("no p :" + valorBooleano.ToString());
valorBooleano = r ^ s;
Console.WriteLine("r xor s :" + valorBooleano.ToString());
valorBooleano = p^r;
Console.WriteLine("p xor r:" + valorBooleano.ToString());

Console.WriteLine("Operadores relacionales-------------------------------");



Console.WriteLine("Operadores de asignación-------------------------------");


Console.WriteLine("Operadores unarios-------------------------------");

