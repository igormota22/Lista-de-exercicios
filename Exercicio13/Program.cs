// 13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

System.Console.Write("Informe o valor de A:");
decimal a = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Informe o valor de B:");
decimal b = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Informe o valor de C:");
decimal c = Convert.ToDecimal(Console.ReadLine());

decimal soma = a + b;

if (soma < c)
{
    System.Console.WriteLine($"A soma de {a} + {b} = {soma} é menor que {c}");
}
