using System;

namespace HungryNinja.Models
{
    public class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy; 
            public bool IsSweet; 
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
            public Food(string name, int cals, bool spicy, bool sweet) {
                Name = name;
                Calories = cals;
                IsSpicy = spicy;
                IsSweet = sweet;
            }
        }
}