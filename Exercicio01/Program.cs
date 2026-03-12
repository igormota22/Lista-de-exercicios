//1. Crie um programa para calcular o volume de uma caixa retangular

System.Console.Write("Digite o comprimento da caixa: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a largura da caixa: ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a altura da caixa: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal volume = comprimento * largura * altura;

System.Console.WriteLine($"O volume da caixa retangular é de: {volume}cm³ ");