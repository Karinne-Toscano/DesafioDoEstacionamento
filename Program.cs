//Parte 1 (Armazena o preço inicial e o preço por hora.)

using System.Collections;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial: ");
int precoInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
int precoPorHora = int.Parse(Console.ReadLine());

List<string> cadastroVeiculos = new List<string>(); // Armazena as placas dos veículos.

//Parte 2 (Mostra o menu com quatro opções e pede para o usuário escolher. Armazena a opção escolhida.)

static string Menu() {
Console.WriteLine("Digite a sua opção: ");
Console.WriteLine("1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar");
return Console.ReadLine();
}

string opcaoDoMenu = "";

// Parte 3 (Apresenta as opções do Menu.)

while (opcaoDoMenu != "4") {

opcaoDoMenu = Menu();

  // Opção 1 (Armazena as placas dos veículos.)

switch (opcaoDoMenu) {

case "1":
Console.WriteLine("Digite a placa do veículo para estacionar: ");
string placa = Console.ReadLine();
cadastroVeiculos.Add(placa);
Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();
break;

  // Opção 2 (Remove as placas dos veículos. Exibe o valor a pagar após remover.)

case "2":
Console.WriteLine("Digite a placa do veículo para remover: ");
placa = Console.ReadLine();
cadastroVeiculos.Remove(placa);
Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
int horas = int.Parse(Console.ReadLine());
Console.WriteLine($"O veículo foi {placa} removido e o preço total foi de: R${precoInicial + precoPorHora * horas}");
Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();
// Retorna ao menu anterior
break;

// Opção 3 (Lista as placas dos veículos cadastrados.)

case "3":
Console.WriteLine("Os veículos estacionados são: " );
    foreach (string v in cadastroVeiculos) {
        Console.WriteLine(v);
        }
Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();
// Retorna ao menu anterior
break;

// Opção 4 (Encerra o programa.)

case "4":
Console.WriteLine("O programa se encerrou.");
break;
}
}