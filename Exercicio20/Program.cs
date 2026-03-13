//20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
//tabuada na forma:
//● 0 x N = 0,
//● 1 x N = 1N,
//● 2 x N = 2N,
//.
//.
//.
//● 10 x N = 10N.

System.Console.Write("Informe o número que deseja ver a tabuada (até x10):");
int numero = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <=10; i++)
{
    System.Console.WriteLine($"{numero} X {i} = {numero * i}");
}
