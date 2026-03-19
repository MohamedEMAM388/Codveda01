namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Variables & Data Types

            int age = 20;         
            double price = 10.5;  
            string name = "Ali"; 
            bool isStudent = true;

            #endregion


            #region Encapsulation
            Person p = new Person();

            p.SetName("Ali");
            Console.WriteLine(p.GetName());

            p.Age = 20;    
            Console.WriteLine(p.Age);
            #endregion

            #region Inhertiance

            Dog d = new Dog();

                d.Eat();  
                d.Bark();


            #endregion


            #region Polymorphism

            Animal a = new Animal();
            a.Sound();

            Dog d2 = new Dog();
            d2.Sound();

            #endregion

            // Methods 
            void SayHello()
            {
                Console.WriteLine("Hello");
            }

            SayHello();



        }
    }
}
