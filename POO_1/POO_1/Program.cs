// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Mouse mouseLogi = new Mouse();
Mouse mouseLogi2 = new Mouse();

mouseLogi.color = "Blanco";
mouseLogi2.color = "Negro";

class Mouse
{
    public string color;
    public double tamaño;
    public int Nbotones;
    public bool TieneStikers;
}