using System;

namespace ExampleGitExercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Dog doge = new Dog();
            doge.Name = "doge";
            doge.Age = 400;

            Console.ReadKey();
        }
    }
}