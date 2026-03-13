//17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
//contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
//variável C e mostrar seu conteúdo na tela.

System.Console.Write("Informe o valor de A:");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o valor de B:");
int b = Convert.ToInt32(Console.ReadLine());

int c;

if (a == b)
{
     c = a + b;
}
else
{
    c = a * b;
}

System.Console.WriteLine($"O valor de C é de: {c}");
