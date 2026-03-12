//12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
//impostos. Imprima o salário inicial, o salário com o aumento e o salário final.
System.Console.Write("Informe o sálario do funcionário:");
decimal salarioInicial  = Convert.ToDecimal(Console.ReadLine());

decimal salarioAumento = salarioInicial + (salarioInicial * 15 /100);
decimal salarioFinal = salarioAumento - (salarioAumento * 8 /100);

System.Console.WriteLine($"Salário inicial: {salarioInicial}");
System.Console.WriteLine($"Salário com aumento: {salarioAumento}");
System.Console.WriteLine($"Salário inicial: {salarioFinal}");
