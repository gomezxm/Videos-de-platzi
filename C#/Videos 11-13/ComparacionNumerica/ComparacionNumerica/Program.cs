//variables a utilizar 
var (value1, value2, value3) = (10, 1, 2);
Console.WriteLine("Los valores son: "+value1+" "+value2 + " " + value3);

/* 
 Operadores de comparacion 
== igual a 
!= diferente a 
> mayor que 
< menor que 
>= mayor o igual 
<+ menor o igual 
 */
// como se ven los resultados de las distintas maneras de comparar
bool result1 = value1 == value2;
Console.WriteLine("El resultado de la compración value1 == value2: "+ result1);

bool result2 = value1 != value2;
Console.WriteLine("El resultado de la compración value1 != value2: " + result2);

bool result3 = value1 > value2;
Console.WriteLine("El resultado de la compración value1 > value2: " + result3);

bool result4 = value1 < value2;
Console.WriteLine("El resultado de la compración value1 < value2: " + result4);

bool result5 = value1 >= value2;
Console.WriteLine("El resultado de la compración value1 >= value2: " + result3);

bool result6 = value1 <= value2;
Console.WriteLine("El resultado de la compración value1 <= value2: " + result4);