// SOLUCION 1.1

Console.Write("Ingresa un número entero: ");

int num = Convert.ToInt32(Console.ReadLine());

int v1 = 0;
int v2 = 1;
var v3 = 0;

for (int i = 2; i <= num; i++ )
{
    v3 = v1 + v2;
    v1 = v2;
    v2 = v3;
}

Console.WriteLine($"El Fibonacci de F{num} es: {v3}");

// SOLUCION 1.2
Console.WriteLine("############################################");
Console.Write("Ingresa un número entero: ");
List<int> nums = new List<int>();

int number = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;
var c = 0;

for (int i = 2; i <= number; i++ )
{
    c = a + b;
    nums.Add(b);
    a = b;
    b = c;
}

if (nums.Contains(number))
{
    Console.WriteLine($"El número {number} es un número de Fibonnaci");
}
else
{
    Console.WriteLine($"El número {number} no es un número de Fibonnaci");
}

// SOLUCION 1.3
Console.WriteLine("############################################");
Console.Write("Ingresa m: ");

int cantidad = int.Parse(Console.ReadLine());

int[] resultado = Fibo(cantidad);

Console.WriteLine($"Los primeros {cantidad} Fibonacci son: {string.Join(", ", resultado)}");

 static int[] Fibo(int cantidad)
{
    int[] numeros = new int[cantidad];
    int vlA = 0;
    int vlB = 1;

    for (int i = 0; i < cantidad; i++)
    {
        numeros[i] = vlA;
        int t = vlA;
        vlA = vlB;
        vlB = t + vlA;
    }
    return numeros;
}