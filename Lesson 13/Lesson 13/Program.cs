namespace Lesson_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Bird bird = new Bird();
            dog.MakeSound();
            bird.MakeSound();
            dog.Move();
            bird.Move();
        }
    }
}
