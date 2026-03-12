//5. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
//vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

System.Console.Write("Informe o salário base:");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Informe o total de vendas:");
int vendas = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o percentual a ser aplicado na comissão (%):");
decimal percentual = Convert.ToDecimal(Console.ReadLine()) /100 ;

decimal comissao = vendas * percentual;

decimal salarioTotal = salarioBase + comissao;

System.Console.WriteLine($"O sálario total foi de: {salarioTotal}R$");
