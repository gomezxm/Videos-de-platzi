// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Apuntador apuntadorPlatzi = new Apuntador();
Apuntador apuntadorPlatzi2 = new Apuntador();

apuntadorPlatzi.color = 'Negro';

apuntadorPlatzi2.color = 'Blanco';
class Apuntador
{
    public string color;
    public double largo;
    public short numeroDeBotones;
    public bool tieneStickrs;
}