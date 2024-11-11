namespace _7_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerPart part = new Processor();

            part.Work();
           
        }
    }

    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("я процессор мне 2.4Ггц");
        }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("я мать твоя");
        }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("жужу я делаю фпсы в играх жужу");
        }
    }

}
