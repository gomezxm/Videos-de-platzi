//Programa para calcular el area de un circulo utilizando constantes

Console.WriteLine("Bienvenido, calculemos circulos");
//Pi * radio*radio(Formula para calcular el area)
const double Pi = 3.1415;//creamos la constante que almacenara el valor de Pi

//Solicitamos al usuario la data de entradas, que en este caso es el valor del radio
Console.WriteLine("Ingrese el valor del radio:");
double radio = Convert.ToDouble(Console.ReadLine());//declaramos la variable justo donde se va ingresar el dato(mala practica)

double result = Pi * radio * radio;//Operacion realizada para obtener el area del circulo
//se imprime a consola el resultado obtenido
Console.WriteLine("El area de tu circulo es de: " + result);