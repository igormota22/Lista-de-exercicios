//3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
//programa deve solicitar ao usuário:
//● A quilometragem inicial do veículo no início da viagem.
//● A quilometragem final ao término da viagem.
//● A quantidade de combustível consumida durante a viagem (em litros).

System.Console.Write("Digite a Km inicial:");
decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite a Km final:");
decimal kmFinal = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Digite o consumo de combustivel consumido:");
decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

decimal distanciaPercorrida = kmFinal - kmInicial;

decimal combustivelConsumidoPorKm = distanciaPercorrida / combustivelConsumido;

System.Console.WriteLine($"O consumo de combustivel por km foi de +- {combustivelConsumidoPorKm} /Km");
