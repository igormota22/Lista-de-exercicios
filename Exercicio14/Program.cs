// 14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

System.Console.Write("Informe o valor 1:");
int v1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o valor 2:");
int v2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o valor 3:");
int v3 = Convert.ToInt32(Console.ReadLine());

if(v1 == v2 || v1 == v3 || v3 == v2)
{
    System.Console.WriteLine("Não informe valores repetidos");
    return;
}
if (v1 > v2 && v2 > v3)
{
    System.Console.WriteLine($"{v1},{v2},{v3}");
}
else if(v3 > v2 && v2 > v1)
{
      System.Console.WriteLine($"{v3},{v2},{v1}");
}
else if(v2 > v3 && v3 > v1)
{
      System.Console.WriteLine($"{v2},{v3},{v1}");
}
else if(v2 > v1 && v1 > v3)
{
      System.Console.WriteLine($"{v2},{v1},{v3}");
}
else
{
      System.Console.WriteLine($"{v3},{v1},{v2}");
}
