//8. Crie um programa para verificar se um número é primo.

System.Console.Write("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());

int resto = numero % 2;

if (numero <= 1)
{
     System.Console.WriteLine($"{numero} não é primo");
     return;

}
else if (numero == 2)
{
     System.Console.WriteLine($"{numero} é primo");
     return;

}
else if (resto == 0)
{
     System.Console.WriteLine($"{numero} não é primo");
     return;

}

for (int i = 3; i * i <= numero; i += 2)
{
     if (numero % i == 0)
     {
          System.Console.WriteLine($"{numero} não é primo");
          return;
     }

}
System.Console.WriteLine($"{numero} é primo");


