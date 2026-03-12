// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
//terreno e depois exibir a área do terreno.

System.Console.Write("Informe a largura do terreno:");
decimal largura = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Informe o comprimento do terreno:");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

decimal area = largura * comprimento;

System.Console.WriteLine($"A area do terreno é de: {area} metros quadrados");