namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog { Breed = "German Sheperd", Age = 2, Weight = 30, EyeColor = "Grey" };
            Dog dog2 = new Dog { Breed = "Collie", Age = 1, Weight = 10, EyeColor = "Blue" };

            Cat cat1 = new Cat { Weight = 20, Age = 3, Color = "Grey" };
            Cat cat2 = new Cat { Weight = 7, Age = 2, Color = "Orange" };

            Bird bird1 = new Bird { Type = "Parrot", Color = "Rainbow", CanFly = false };
            Bird bird2 = new Bird { Type = "Eagle", Color = "Brown", CanFly = true };

            List<IPet> pets = new List<IPet>();
            pets.AddRange(new IPet[] { dog1, dog2, cat1, cat2, bird1, bird2 });

            foreach (var pet in pets)
            {
                var aDog = pet as Dog;
                var aCat = pet as Cat;
                var aBird = pet as Bird;

                if(aDog is not null)
                {
                    Console.WriteLine($"The Dog's breed is {aDog.Breed}, Age is {aDog.Age}, Weight is {aDog.Weight}, and Eye Color is {aDog.EyeColor}");
                }
                if (aCat is not null)
                {
                    Console.WriteLine($"The Cat's weight is {aCat.Weight}, Age is {aCat.Age}, Color is {aCat.Color}.");
                }
                if(aBird is not null)
                {
                    Console.WriteLine($"This bird is a(n) {aBird.Type}, Color is {aBird.Color}, Bird can Fly?: {aBird.CanFly}");
                }
            }
        }
        
    }
}
