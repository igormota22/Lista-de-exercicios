//7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

System.Console.Write("Digite a nota da prova 1:");
double p1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Digite a nota da prova 2:");
double p2 = Convert.ToDouble(Console.ReadLine());

double peso1 = 3;
double peso2 = 2;

double calculoNotas = (p1 * peso1) + (p2 * peso2);


double mediaPonderada = calculoNotas / (peso1 + peso2);

System.Console.WriteLine($"A média ponderada das provas foi de: {mediaPonderada.ToString("F1")}");