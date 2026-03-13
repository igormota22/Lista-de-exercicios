// 16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

System.Console.Write("Informe um número:");
double numero = Convert.ToDouble(Console.ReadLine());

double resto = numero % 2;

if (resto == 0)
{
    System.Console.WriteLine("É PAR");
}
else
{
    System.Console.WriteLine("É IMPAR");
}
