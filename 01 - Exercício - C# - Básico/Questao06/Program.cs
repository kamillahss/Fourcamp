// Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

int idFunc, horasTrab;
double salario, valorHora;

idFunc = Convert.ToInt32(Console.ReadLine());
horasTrab = Convert.ToInt32(Console.ReadLine());
valorHora = Convert.ToDouble(Console.ReadLine());

salario = horasTrab * valorHora;
Console.WriteLine($"NUMBER: {idFunc} \nSALARY: U${salario}");

