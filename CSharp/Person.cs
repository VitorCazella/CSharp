using System;

namespace CSharp{

    public class Person{
        private int age;
        public void SetAge(int n){
            age = n;
        }

        public int Age {
            get => age;
            set => age = value;
        }
        public void SayHello(string person){
            Console.WriteLine($"Hi from {person}");
        }
    }

    public class Student : Person {
        public void GoToClass(){
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge(){
            Console.WriteLine($"My age is: {Age} years old");
        }
    }

    public class Teacher : Person {
        private string subject;


        public void Explain(string sub){
            subject = sub;
            Console.WriteLine($"Explanation begins for {subject}");
        }
    }
}