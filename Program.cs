namespace MyFirstProgram
{//Ester Zetterlund .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = (4); //Tilldelar ett värde

            if (num > 10) //Kollar om värdet är större än 10
            {
                Console.WriteLine("Talet är stort!"); //Om talet hade varit större än 10 
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!"); //Om talet är mindre eller likamed 10
            }

            Console.WriteLine("Vad heter du?"); //Ställer en fråga

            string name = Console.ReadLine(); //Dom får svara

            Console.WriteLine($"Hej {name}"); //Skriver hej och det namn dom har svarat

            int a = 0; //Tilldelar ett värde 

            while (a <= 4) //Det ska fortsätta upp till 4

            {
                Console.WriteLine(a); 
                a++; //plussar på 1 för varje gång loopen körs
            }

        }
    }
}