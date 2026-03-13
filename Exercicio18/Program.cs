// 18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

int[] numerosImpares = new int[201];

for (int i = 100; i < numerosImpares.Length; i++)

{
    numerosImpares[i] = i;
   
   if(numerosImpares[i] % 2 != 0)
    {
          System.Console.WriteLine($"{numerosImpares[i]}");
    }
}
