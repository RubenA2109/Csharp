// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Hello.ws;

internal class Program
{

    static void testaNomes(string child1, string child2 = "", string child3 = "")
    {
        if (child2 == "")
        {
            Console.WriteLine(child1);
        }
        else
        {
            if (child3 == "")
            {
                Console.WriteLine(child2);
            }
            else
            {
                Console.WriteLine(child3);
            }
        }
    }

    static int MyMethod(int num)
    {
        return num + 1;
    }

    static void Main(string[] args)
    {
        Carro newCar = new Carro();
        newCar.marca = "Oopel";
        newCar.modelo = "Corsa";
        newCar.matricula = "00-aa-00";
        newCar.ano = 2004;
        newCar.mostraDados();
    }


    //int myNum = 5;
    //double myDoubleNum = 5.99D;
    //float myFloatNum = 1.123456789f;
    //char myLetter = 'D';
    //bool MyBool = true;
    //string myText = "Hello";

    //Console.Write(myNum);
    //Console.Write(myDoubleNum);

}


