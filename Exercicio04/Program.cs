//4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

System.Console.Write("Informe a temperatura em Fahrenheit:");
double f = Convert.ToDouble(Console.ReadLine());

double c = (f - 32) * (5 / 9);

System.Console.WriteLine($"A temperatura de {f} Fahrenheit é de {c} em graus Célsius ");
