
decimal peso = 0;
decimal altura = 0;
decimal resultado = 0.0m;

Console.WriteLine("Digite sua altura: ");
Console.WriteLine("Utilize virgula para separar, por exemplo: 1,60");
altura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite seu peso: ");
peso = Convert.ToDecimal(Console.ReadLine());

resultado = peso / (altura * altura);
decimal result = decimal.Round(resultado, 2);

Console.WriteLine("Esse é o seu IMC: " + result);