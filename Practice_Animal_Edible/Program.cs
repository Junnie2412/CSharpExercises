
class Program{
    static void Main(string[] args)
    {
        Animal[] animals=new Animal[2];
        animals[0] = new Chicken();
        animals[1] = new Tiger();

        foreach(Animal animal in animals){
            Console.WriteLine(animal.MakeSound());

            if(animal is Chicken){
                Edible edibler=(Chicken)animal;
                Console.WriteLine(edibler.HowToEat());
            }
        }
    }
}
