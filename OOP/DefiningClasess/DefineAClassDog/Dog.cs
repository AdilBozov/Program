using System;

namespace Dogs
{

    public class Dog
    {

        public string name;

        public string Name 
        {
            get 
            {
                return this.name;
            }
            set
            {
                //if (value == null || value == "")
                //{
                //    throw new ArgumentNullException("Name");
                //}
                this.name = value;
            }
        }

        public string Breed { get; set; }

        public Dog() : this(null, null)
        {

        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) says Bauuuuuu!", this.Name ?? "NO name dog", this.Breed);
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}) says Bauuuuuu!", this.Name ?? "NO name dog", this.Breed);
        }
    }
}