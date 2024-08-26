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
int num1 = 5;
int num2 = 10;

// Operadores relacionales
bool esMayor = num1 > num2;        // false
bool esMenor = num1 < num2;        // true
bool esIgual = num1 == num2;       // false
bool esDiferente = num1 != num2;   // true
bool esMayorOIgual = num1 >= num2; // false
bool esMenorOIgual = num1 <= num2; // true

Console.WriteLine("");

Console.WriteLine("El número: " + num1.ToString() + " > " + num2.ToString() + " : " + esMayor.ToString());
Console.WriteLine("El número: " + num1.ToString() + " < " + num2.ToString() + " : " + esMenor.ToString());
Console.WriteLine("El número: " + num1.ToString() + " == igual " + num2.ToString() + " : " + esIgual.ToString());
Console.WriteLine("El número: " + num1.ToString() + " != diferente " + num2.ToString() + " : " + esDiferente.ToString());
Console.WriteLine("El número: " + num1.ToString() + " >= " + num2.ToString() + " : " + esMayorOIgual.ToString());
Console.WriteLine("El número: " + num1.ToString() + " <= " + num2.ToString() + " : " + esMenorOIgual.ToString());
Console.WriteLine("");


Console.WriteLine("Operadores de asignación-------------------------------");
Console.WriteLine("");
int e = 10;
Console.WriteLine("El valor de la variable e es: " + e.ToString());
Console.WriteLine("");
// Operadores de asignación

e += 5;  // Equivalente a e = e + 5. e ahora es 15

Console.WriteLine("El valor de la variable e es: " + e.ToString() + " cambiando el valor con el operador +=");
e -= 3;  // Equivalente a e = e - 3. e ahora es 12
Console.WriteLine("El valor de la variable e es: " + e.ToString() + " cambiando el valor con el operador -=");
e *= 2;  // Equivalente a e = e * 2. e ahora es 24
Console.WriteLine("El valor de la variable e es: " + e.ToString() + " cambiando el valor con el operador *=");
e /= 4;  // Equivalente a e = e / 4. e ahora es 6
Console.WriteLine("El valor de la variable e es: " + e.ToString() + " cambiando el valor con el operador /=");
e %= 2;  // Equivalente a e = e % 2. e ahora es 0
Console.WriteLine("El valor de la variable e es: " + e.ToString() + " cambiando el valor con el operador %=");
Console.WriteLine("");

Console.WriteLine("Operadores unarios-------------------------------");

Console.WriteLine("");
int c = 5;
Console.WriteLine("Valor de la variable c es:"+c.ToString());

// Operadores unarios
c++;     // Incrementa c en 1. c ahora es 6
Console.WriteLine("El valor de la variable incrementa en 1 usando el operador ++"+c.ToString());
c--;     // Decrementa c en 1. c ahora es 5
Console.WriteLine("El valor de la variable decrementa en 1 usando el operador --" + c.ToString());

int d = -c; // Operador negativo, d ahora es -5

bool esVerdadero = true;
bool noEsVerdadero = !esVerdadero; // Negación lógica. noEsVerdadero ahora es false


