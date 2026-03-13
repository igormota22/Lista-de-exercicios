//21. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
//resultado.
//a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//b. Pesquise sobre “fatorial”

System.Console.Write("Informe o número:");
int n = Convert.ToInt32(Console.ReadLine());
int f = 1;
System.Console.Write($"{n}! = ");

for (int i = n; i >= 1; i--)
{
    f *= i ;
    System.Console.Write(i);
    if (i > 1) System.Console.Write(" X ");
    
    
}
System.Console.WriteLine($" = {f}");