using Domain.UseCase.Class;

Operaciones operador = new();

Console.WriteLine("El reultado de la suma es: " + operador.sumar(10,10));
Console.WriteLine("El reultado de la resta es: " + operador.restar(10, 2));
Console.WriteLine("El reultado de la multiplicación es: " + operador.multiplicar(3, 5));
Console.WriteLine("El reultado de la división es: " + operador.dividir(25, 5));

