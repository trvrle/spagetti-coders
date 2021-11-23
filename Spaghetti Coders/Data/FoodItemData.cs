using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;
using Spaghetti_Coders.Controls;

namespace Spaghetti_Coders.Data
{
    public class FoodItemData
    {
        public const string SpicyRamenTitle = "Spicy Ramen";
        public const string SpicyRamenDescription = "Spicy miso based soup topped with sesame, green onions, corn seeds, beansprouts, enoki mushrooms, and egg.";
        public const string SpicyRamenImageSource = "/Images/spicy-ramen.jpg";
        public const string SpicyRamenPrice = "$12.99";
        public static readonly List<FoodCategory> SpicyRamenCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Main };

        public const string TempuraTitle = "Tempura";
        public const string TempuraDescription = "Fresh shrimp dipped in tempura batter and deep-fried until perfectly crispy.";
        public const string TempuraImageSource = "/Images/tempura.jpg";
        public const string TempuraPrice = "$11.99";
        public static readonly List<FoodCategory> TempuraCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Sides };

        public const string MisoRamenTitle = "Miso Ramen";
        public const string MisoRamenDescription = "Miso ramen soup topped with sesame, green onions, seaweed, carrots, and egg.";
        public const string MisoRamenImageSource = "/Images/miso-ramen.jpg";
        public const string MisoRamenPrice = "$12.99";
        public static readonly List<FoodCategory> MisoRamenCategories = new List<FoodCategory> { FoodCategory.Specials };

        public const string CaliforniaRollTitle = "California Roll";
        public const string CaliforniaRollDescription = "California Rolls with a layer of rice on the outside and a sheet of nori on the inside, and include avocado, imitation crab, cucumber, and tobiko (flying fish roe).";
        public const string CaliforniaRollImageSource = "/Images/california-roll.jpg";
        public const string CaliforniaRollPrice = "$8.99";
        public static readonly List<FoodCategory> CaliforniaRollCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Main };

        public const string TunaRollTitle = "Tuna Roll";
        public const string TunaRollDescription = "Tuna Rolls with sashimi grade tuna tossed in sesame Sriracha sauce, topped with spicy mayo.";
        public const string TunaRollImageSource = "/Images/tuna-roll.jpg";
        public const string TunaRollPrice = "$12.99";
        public static readonly List<FoodCategory> TunaRollCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Drinks };

        public const string SalmonSushiRollTitle = "Salmon Sushi Roll";
        public const string SalmonSushiRollDescription = "Tuna Rolls with sashimi grade tuna tossed in sesame Sriracha sauce, topped with spicy mayo.";
        public const string SalmonSushiRollImageSource = "/Images/salmon-sushi-roll.jpg";
        public const string SalmonSushiRollPrice = "$12.99";
        public static readonly List<FoodCategory> SalmonSushiRollCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Desserts };

        public const string SalmonSushiTitle = "Salmon Sushi";
        public const string SalmonSushiDescription = "Salmon Sushi Description";
        public const string SalmonSushiImageSource = "/Images/salmon-sushi.jpg";
        public const string SalmonSushiPrice = "$8.99";
        public static readonly List<FoodCategory> SalmonSushiCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Sides, FoodCategory.Main };

        public static List<FoodItem> GetFoodItemList()
        {
            return new List<FoodItem>
            {
                new FoodItem
                {
                    Title = SpicyRamenTitle,
                    Description = SpicyRamenDescription,
                    ImageSource = new BitmapImage( new Uri( SpicyRamenImageSource, UriKind.Relative ) ),
                    Price = SpicyRamenPrice,
                    Categories = SpicyRamenCategories
        },
                new FoodItem
                {
                    Title = TempuraTitle,
                    Description = TempuraDescription,
                    ImageSource = new BitmapImage( new Uri( TempuraImageSource, UriKind.Relative ) ),
                    Price = TempuraPrice,
                    Categories = TempuraCategories
                },
                new FoodItem
                {
                    Title = MisoRamenTitle,
                    Description = MisoRamenDescription,
                    ImageSource = new BitmapImage( new Uri( MisoRamenImageSource, UriKind.Relative ) ),
                    Price = MisoRamenPrice,
                    Categories = MisoRamenCategories
                },
                new FoodItem
                {
                    Title = CaliforniaRollTitle,
                    Description = CaliforniaRollDescription,
                    ImageSource = new BitmapImage( new Uri( CaliforniaRollImageSource, UriKind.Relative ) ),
                    Price = CaliforniaRollPrice,
                    Categories = CaliforniaRollCategories
                },
                new FoodItem
                {
                    Title = TunaRollTitle,
                    Description = TunaRollDescription,
                    ImageSource = new BitmapImage( new Uri( TunaRollImageSource, UriKind.Relative ) ),
                    Price = TunaRollPrice,
                    Categories = TunaRollCategories
                },
                new FoodItem
                {
                    Title = SalmonSushiRollTitle,
                    Description = SalmonSushiRollDescription,
                    ImageSource = new BitmapImage( new Uri( SalmonSushiRollImageSource, UriKind.Relative ) ),
                    Price = SalmonSushiRollPrice,
                    Categories = SalmonSushiRollCategories
                },
                new FoodItem
                {
                    Title = SalmonSushiTitle,
                    Description = SalmonSushiDescription,
                    ImageSource = new BitmapImage( new Uri( SalmonSushiImageSource, UriKind.Relative ) ),
                    Price = SalmonSushiPrice,
                    Categories = SalmonSushiCategories
                }
            };
        }
    }
}
