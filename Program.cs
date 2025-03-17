namespace ICE_TASK_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape rectangle = new Rectangle("MyRectangle", 5, 3);
            Shape circle = new Circle("MyCircle", 4);

            rectangle.Display();
            circle.Display();


            Console.ReadKey();


        }
    }
}
