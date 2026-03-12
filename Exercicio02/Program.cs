//2. Crie um programa para calcular o volume de um Cilindro

System.Console.Write("Digite o raio do cilindro: ");
decimal raio = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a altura do cilindro: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal areaBase = 3.14m * (raio * raio);

decimal volume = areaBase * altura ;

System.Console.WriteLine($"O volume do cilindro é de: {volume.ToString("F2")}");
