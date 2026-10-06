
namespace OOPsProject
{
    struct Student1
    {
        int a = 20;
        public Student1()
        {

        }
        void Display()
        {
            Console.WriteLine("Hi");
        }
        static void Main()
        {
            Student1 s1 = new Student1();
            Console.WriteLine(s1.a);

            s1.Display();
        }
    }
}