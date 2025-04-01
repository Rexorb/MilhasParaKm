/*
Exercício MilhasParaKm
Receba uma medida em milhas e exiba seu equivalente em quilômetros. A medida em km é 1,609 vezes a medida em milhas.

Entre com a medida (em milhas): 1
1,609 Km
*/

double km = 1.609;
Console.WriteLine("Entre com o total de milhas");
double milhas = Convert.ToDouble(Console.ReadLine());
double resultado = km * milhas;
Console.WriteLine($"A medida convertida é de: {resultado} kilômetros");


