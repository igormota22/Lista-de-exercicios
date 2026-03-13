//15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
//a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) 2. Elabore um algoritmo que leia o
//peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
//● IMC em adultos Condição
//● Abaixo de 18,5
//● Abaixo do peso
//● Entre 18,5 e 25 Peso normal
//● Entre 25 e 30
//● Acima do peso
//● Acima de 30 obeso

System.Console.Write("Informe seu peso:");
double peso = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Informe sua altura:");
double altura = Convert.ToDouble(Console.ReadLine()); 

double imc = peso / (altura * altura);

System.Console.WriteLine($"Seu IMC é de {imc.ToString("F2")}");

if (imc < 18.5)
{
    System.Console.WriteLine("Abaixo do peso");
}
else if (imc >= 18.5 && imc <= 25)
{
    System.Console.WriteLine("Peso normal");
}
else if(imc >= 25 && imc <= 30)
{
    System.Console.WriteLine("Acima do peso");
}
else
{
    System.Console.WriteLine("Obeso");
}