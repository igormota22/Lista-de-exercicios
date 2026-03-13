// 19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
//encontram no conjunto dos números de 1 até 500.

int[] numerosImpares = new int[500];
int soma = 0;
int qnt = 0;

for (int i = 3; i < numerosImpares.Length; i += 6)

{
    numerosImpares[qnt] = i;
    System.Console.WriteLine($"{numerosImpares[qnt]}");
    qnt++;
   
}
 soma = (numerosImpares[0] + numerosImpares[qnt - 1]) * qnt / 2;
 System.Console.WriteLine($"A soma dos valores foi de: {soma}");

