//6. Crie um programa para calcular a média harmônica das notas de um Aluno

System.Console.Write("Informe a nota 1:");
double n1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Informe a nota 2:");
double n2 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Informe a nota 3:");
double n3 = Convert.ToDouble(Console.ReadLine());

double reciprocros = (1/n1) + (1/n2) + (1/n3);

double mediaH = 3/reciprocros;

System.Console.WriteLine($"A média harmonica é de: {mediaH.ToString("F2")}");

