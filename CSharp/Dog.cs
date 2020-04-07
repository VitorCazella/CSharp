using System;

namespace CSharp
{
    class Dog : Animal{
        private string type;

        public string Type{
            get => type;
            set => type = value;
        }

        private int dogID;

        public Dog(string dogType){
            dogType = GetNextID() + 2000;
            
        }
    }
}