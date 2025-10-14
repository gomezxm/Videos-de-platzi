//Otra forma de declarar las variables
var(value1,value2,value3) = (true,true,false);

bool resultAnd = value1 && value2 && value3;//esta variable recibira el 
Console.WriteLine(resultAnd);

bool resultOr= value1 || value2 || value3;
Console.WriteLine(resultOr);

bool resultAndOr = (value1 && value2) || value3;
Console.WriteLine(resultAndOr);

bool resultNot = !value1;
Console.WriteLine(resultNot);

bool resultXor = (value1 ^ value2) ^ value3;
Console.WriteLine(resultXor);