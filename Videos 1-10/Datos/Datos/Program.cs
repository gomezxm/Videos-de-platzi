//Variables con la que se manejara la data de entrada y el resultado
int sideA;
int sideB;
int reslt;
// le solicito al usario la data de entrada
Console.WriteLine("Calcula el area de un triangulo");
Console.WriteLine("Ingrese el valor del lado A:");
sideA = Convert.ToInt32(Console.ReadLine()); // recibo la data de entrada

Console.WriteLine("Ingrese el valor del lado B: ");
sideB = Convert.ToInt32(Console.ReadLine()); // recibo la data de entrada

reslt = sideA * sideB; //realizo la operacion
//imprimo a consola la respuesta
Console.WriteLine("El lado A es: " + sideA + ", el lado B:" + sideB + " El resultado es: " + reslt);