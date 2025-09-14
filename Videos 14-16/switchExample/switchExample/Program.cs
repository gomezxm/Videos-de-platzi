//se declaran las variables a utilizar ya instanciadas
int totalPlayer = 0;
int TotalDealer = 15;
string Message;
string switchControl = "menu";


switch (switchControl)
{
    case "menu":
        Console.WriteLine("Welcome al c a s i n o ");
        Console.WriteLine("Escriba '21' para jugar al 21");
        switchControl = Console.ReadLine();
        break;

    case "21":
        // Condicionales para el juego con sus respectivos mensajes
        if (totalPlayer > TotalDealer && totalPlayer <= 21)
        {
            Message = "Venciste al dealer. Felicidades.";
        }
        else if (totalPlayer > 21)
        {
            Message = "Perdiste versus el dealer. Te pasaste de 21.";
        }
        else if (totalPlayer <= TotalDealer)
        {
            Message = "Perdiste versus el dealer. Lo siento.";
        }
        else
        {
            Message = "Condición no válida.";
        }
        //se imprime su respectivo mensaje dependiendo de la condicional
        Console.WriteLine(Message);
        break;

    default:
        Console.WriteLine("Valor ingresado no valido en el casino");
        break;
}