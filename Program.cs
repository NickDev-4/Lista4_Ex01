Console.Clear();

int numero;

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0){
    Console.WriteLine("{0} é par", numero);
}

else {
    Console.WriteLine("{0} é ímpar", numero);
}