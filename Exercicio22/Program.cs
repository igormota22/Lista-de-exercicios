// 22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

int n1 = 0, n2 = 1;

System.Console.Write("Informe o número:");
int n = Convert.ToInt32(Console.ReadLine());


System.Console.Write($"{n1}");
for(; n2 <= n;)
{
    int proximo = n1 + n2;
    System.Console.Write("," + n2);
    n1 = n2;
    n2 = proximo;
}