using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
    //instancją klasy jest obiekt wyprodukowany w tej klasie
        static void Main(string[] args)
        {
            Human h = new Human();
            Human x = new Human();
            Human z = new Human();
                h.setName("Marcin");
                x.setName("Paweł");
                z.setName("Dupa");
            Console.WriteLine(h.getName());
            Console.WriteLine(x.getName());
            Console.WriteLine("Imie obiektu z: "+z.getName());
            Console.ReadLine();
        }   
    }

class Human
{
    string name;

    public string getName()
    {
        return name;
    }

    public void setName(string sName)
    {
        if (sName == "Dupa")
        {
            Console.WriteLine("Error!");
            this.name = "Nie ustawiono";
        }
        else
            this.name = sName;
    }
}