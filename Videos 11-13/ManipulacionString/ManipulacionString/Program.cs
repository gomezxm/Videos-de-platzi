//Se imprime el nombre a utilizar 
Console.WriteLine("Ricardo Perez ID!");
//se declaran datos a utilizar
int height = 168;
int age = 89;
string name = "Ricardo Perez";
string information = "Nacio  en Hidalgo, es estudiante de gastronomia y astronomia ";
var hobby = "Deportista";

//se agregan los datos a una cadena para mejor uso de las variables
string informationCard = $"La informacion de {name} es la siguiente \n Su edad es {age} "+
    $"Su altura es de {height} cms\n Informacion relevante {information}\n ademas, su hobby es de: {hobby}";
//se imprime todo el string
Console.WriteLine(informationCard);