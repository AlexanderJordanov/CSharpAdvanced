﻿namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person1 = new Person{
                Name = "Peter",
                Age = 20,
            };
            Person person2 = new Person
            {
                Name = "George",
                Age = 18,
            };
            Person person3 = new Person
            {
                Name = "Jose",
                Age = 43,
            };
        }
    }
}
