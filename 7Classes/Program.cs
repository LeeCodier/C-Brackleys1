using System;

namespace Classes{
    //a class is basically a a blueprint for an object instance
    //multiple instances can be created
    class Dog
    {
      public string name;
      public int age;
      public bool  purebread;
      public void Bark(){
        Console.WriteLine(name + "starts to bark");
      }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Dog dog01 = new Dog();

        dog01.name = "spot";
        dog01.age = 4;
        dog01.Bark();

        Dog dog2 = new Dog();

                dog01.name = "Ben";
        dog01.age = 1;
        dog01.Bark();
      
        }
    }
}