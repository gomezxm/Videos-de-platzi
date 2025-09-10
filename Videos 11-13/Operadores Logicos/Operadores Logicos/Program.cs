//se declaran las varibales booleanas a utilizar
bool value1 = true;
bool value2 = true;
bool value3 = false;

bool resultAnd = value1 && value2 && value3;//esta variable recibira el 
Console.WriteLine(resultAnd);

bool resultOr= value1 || value2 || value3;
Console.WriteLine(resultOr);

bool resultAndOr = (value1 && value2) || value3;
Console.WriteLine(resultAndOr);