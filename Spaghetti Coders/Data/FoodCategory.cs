using System;
using System.Collections.Generic;
using System.Text;

namespace Spaghetti_Coders.Data
{
    public class FoodCategory
    {
        private FoodCategory( string value ) { Value = value; }

        public string Value { get; private set; }

        public static FoodCategory Specials { get { return new FoodCategory( "Today's Specials" ); } }
        public static FoodCategory Main { get { return new FoodCategory( "Main" ); } }
        public static FoodCategory Sides { get { return new FoodCategory( "Sides" ); } }
        public static FoodCategory Desserts { get { return new FoodCategory( "Desserts" ); } }
        public static FoodCategory Drinks { get { return new FoodCategory( "Drinks" ); } }

    }
}
