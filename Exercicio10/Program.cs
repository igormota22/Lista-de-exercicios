// 10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
//pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
//dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
//contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
//de pães e de broas, e depois calcular os dados solicitados.


System.Console.Write("Informe quantos paezinhos foram vendidos:");
int qntPaes = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe quantas broas foram vendidas:");
int qntBroas = Convert.ToInt32(Console.ReadLine());

decimal precoPao = 0.12m; 
decimal precoBroa = 1.50m;

decimal totalArrecadado = (qntPaes * precoPao) + (qntBroas * precoBroa);
decimal poupanca = totalArrecadado * 10 / 100;

System.Console.WriteLine($"O total arrecado do dia foi de {totalArrecadado}R$.");
System.Console.WriteLine($"Deve guardar {poupanca}R$ na poupança");


