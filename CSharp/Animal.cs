using System;

namespace CSharp
{
    class Animal{
        private string name;
        protected static int ID; // static attatch the ID to the class not the object
        private int age;

        static Animal(){
            ID = 0;
        }

        protected int GetNextID(){
            return ++ID;
        }

        public virtual void MakingVoice(){
            Console.WriteLine("");
        }
    }
}
