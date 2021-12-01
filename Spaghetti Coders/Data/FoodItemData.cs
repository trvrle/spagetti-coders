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
        public const int SpicyRamenCalories = 200;
        public const float SpicyRamenPrice = 12.99F;
        public const float SpicyRamenDiscount = 3.00F;
        public const string SpicyRamenQuantity = "bowl";
        public static readonly List<FoodCategory> SpicyRamenCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Main };
        public static readonly Dictionary<string, List<string>> SpicyRamenModifications = new Dictionary<string, List<string>>
        {
            {
                "Spice",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Green Onion",
                new List<string>
                {
                    "None",
                    "One",
                    "Two"
                }
            },
            {
                "Egg",
                new List<string>
                {
                    "None",
                    "One",
                    "Two (+1)"
                }
            },
            {
                "Soup",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string TempuraTitle = "Tempura";
        public const string TempuraDescription = "Perfectly crispy deep-fried shrimps dipped in tempura batter. Served with special tempura dipping sauce. The batter used to make the tempura batter consists of flour, water, cornstarch, and eggs.";
        public const string TempuraImageSource = "/Images/tempura.jpg";
        public const int TempuraCalories = 246;
        public const float TempuraPrice = 11.99F;
        public const float TempuraDiscount = 2.00F;
        public const string TempuraQuantity = "10 pcs";
        public static readonly List<FoodCategory> TempuraCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Sides };
        public static readonly Dictionary<string, List<string>> TempuraModifications = new Dictionary<string, List<string>>
        {
            {
                "Dipping_Sauce",
                new List<string>
                {
                    "None",
                    "One",
                    "Two"
                }
            }
        };

        public const string MisoRamenTitle = "Miso Ramen";
        public const string MisoRamenDescription = "Miso ramen soup topped with sesame, green onions, seaweed, carrots, and egg.";
        public const string MisoRamenImageSource = "/Images/miso-ramen.jpg";
        public const int MisoRamenCalories = 200;
        public const float MisoRamenPrice = 12.99F;
        public const string MisoRamenQuantity = "bowl";
        public static readonly List<FoodCategory> MisoRamenCategories = new List<FoodCategory> { FoodCategory.Main };
        public static readonly Dictionary<string, List<string>> MisoRamenModifications = new Dictionary<string, List<string>>
        {
            {
                "Green_Onion",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Egg",
                new List<string>
                {
                    "None",
                    "One",
                    "Two (+1)"
                }
            },
            {
                "Sesame",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string CaliforniaRollTitle = "California Roll";
        public const string CaliforniaRollDescription = "California Rolls with a layer of rice on the outside and a sheet of nori on the inside, and include avocado, imitation crab, cucumber, and tobiko (flying fish roe).";
        public const string CaliforniaRollImageSource = "/Images/california-roll.jpg";
        public const int CaliforniaRollCalories = 262;
        public const float CaliforniaRollPrice = 8.99F;
        public const string CaliforniaRollQuantity = "8 pcs";
        public static readonly List<FoodCategory> CaliforniaRollCategories = new List<FoodCategory> {FoodCategory.Main };
        public static readonly Dictionary<string, List<string>> CaliforniaRollModifications = new Dictionary<string, List<string>>
        {
            {
                "Imitation_Crab",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            },
            {
                "tobiko_(flying_fish_roe)",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string TunaRollTitle = "Tuna Roll";
        public const string TunaRollDescription = "Tuna Rolls with sashimi grade tuna tossed in sesame Sriracha sauce, topped with spicy mayo.";
        public const string TunaRollImageSource = "/Images/tuna-roll.jpg";
        public const int TunaRollCalories = 176;
        public const float TunaRollPrice = 12.99F;
        public const string TunaRollQuantity = "9 pcs";
        public static readonly List<FoodCategory> TunaRollCategories = new List<FoodCategory> { FoodCategory.Main };
        public static readonly Dictionary<string, List<string>> TunaRollModifications = new Dictionary<string, List<string>>
        {
            {
                "Spicy_Mayo",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string SalmonSushiRollTitle = "Salmon Sushi Roll";
        public const string SalmonSushiRollDescription = "Tuna Rolls with sashimi grade tuna tossed in sesame Sriracha sauce, topped with spicy mayo.";
        public const string SalmonSushiRollImageSource = "/Images/salmon-sushi-roll.jpg";
        public const int SalmonSushiRollCalories = 220;
        public const float SalmonSushiRollPrice = 12.99F;
        public const string SalmonSushiRollQuantity = "8 pcs";
        public static readonly List<FoodCategory> SalmonSushiRollCategories = new List<FoodCategory> { FoodCategory.Main };
        public static readonly Dictionary<string, List<string>> SalmonSushiRollModifications = new Dictionary<string, List<string>>
        {
            {
                "Spicy_Mayo",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string SalmonSushiTitle = "Salmon Sushi";
        public const string SalmonSushiDescription = "A ball of sushi rice containing vinegar topped with a slice of salmon.";
        public const string SalmonSushiImageSource = "/Images/salmon-sushi.jpg";
        public const int SalmonSushiCalories = 190; 
        public const float SalmonSushiPrice = 8.99F;
        public const string SalmonSushiQuantity = "4 pcs";
        public static readonly List<FoodCategory> SalmonSushiCategories = new List<FoodCategory> { FoodCategory.Main };
        public static readonly Dictionary<string, List<string>> SalmonSushiModifications = new Dictionary<string, List<string>>
        {

        };

        public const string AgedashiTofuWithBrothTitle = "Agedashi Tofu with Broth";
        public const string AgedashiTofuWithBrothDescription = "Agedashi Tofu is soft tofu coated with potato starch and deep-fried so that the outer shell is crispy.";
        public const string AgedashiTofuWithBrothImageSource = "/Images/agedashi-tofu-with-broth.jpg";
        public const int AgedashiTofuWithBrothCalories = 140;
        public const float AgedashiTofuWithBrothPrice = 6.99F;
        public const string AgedashiTofuWithBrothQuantity = "bowl";
        public static readonly List<FoodCategory> AgedashiTofuWithBrothCategories = new List<FoodCategory> { FoodCategory.Sides };
        public static readonly Dictionary<string, List<string>> AgedashiTofuWithBrothModifications = new Dictionary<string, List<string>>
        {
            {
                "Broth",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string JapanesePancakesTitle = "Japanese Pancakes";
        public const string JapanesePancakesDescription = "Japanese savory pancakes made with shredded cabbage, flour, eggs, and water.";
        public const string JapanesePancakesImageSource = "/Images/japanese-pancakes.jpg";
        public const int JapanesePancakesCalories = 800;
        public const float JapanesePancakesPrice = 7.99F;
        public const string JapanesePancakesQuantity = "2 pcs";
        public static readonly List<FoodCategory> JapanesePancakesCategories = new List<FoodCategory> { FoodCategory.Sides };
        public static readonly Dictionary<string, List<string>> JapanesePancakesModifications = new Dictionary<string, List<string>>
        {
            {
                "Cabbage",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string KaraageTitle = "Karaage";
        public const string KaraageDescription = "Chicken thigh coated in potato starch and deep-friend in hot oil until crispy.";
        public const string KaraageImageSource = "/Images/karaage.jpg";
        public const int KaraageCalories = 452;
        public const float KaraagePrice = 11.50F;
        public const string KaraageQuantity = "10 pcs";
        public static readonly List<FoodCategory> KaraageCategories = new List<FoodCategory> { FoodCategory.Sides };
        public static readonly Dictionary<string, List<string>> KaraageModifications = new Dictionary<string, List<string>>
        {
            {
                "Dipping_Sauce",
                new List<string>
                {
                    "None",
                    "One",
                    "Two"
                }
            }
        };

        public const string GreenTeaIceCreamTitle = "Green Tea Ice Cream";
        public const string GreenTeaIceCreamDescription = "Matcha green tea flavored ice cream";
        public const string GreenTeaIceCreamImageSource = "/Images/green-tea-ice-cream.jpg";
        public const int GreenTeaIceCreamCalories = 140;
        public const float GreenTeaIceCreamPrice = 3.99F;
        public const string GreenTeaIceCreamQuantity = "scoop";
        public static readonly List<FoodCategory> GreenTeaIceCreamCategories = new List<FoodCategory> { FoodCategory.Desserts };
        public static readonly Dictionary<string, List<string>> GreenTeaIceCreamModifications = new Dictionary<string, List<string>>
        {

        };

        public const string IceCreamMochiTitle = "Ice Cream Mochi";
        public const string IceCreamMochiDescription = "Consists of small, round confections that have a soft, pounded sticky rice dumpling (mochi) formed around an ice cream filling. The ice cream flavors the confection while the mochi adds sweetness and texture.";
        public const string IceCreamMochiImageSource = "/Images/ice-cream-mochi.jpg";
        public const int IceCreamMochiCalories = 450;
        public const float IceCreamMochiPrice = 9.50F;
        public const string IceCreamMochiQuantity = "4 confections";
        public static readonly List<FoodCategory> IceCreamMochiCategories = new List<FoodCategory> { FoodCategory.Desserts };
        public static readonly Dictionary<string, List<string>> IceCreamMochiModifications = new Dictionary<string, List<string>>
        {

        };

        public const string StrawberryChocolateMochiTitle = "Strawberry Chocolate Mochi";
        public const string StrawberryChocolateMochiDescription = "Fresh strawberries dipped in melted milk chocolate and wrapped in mochi rice cakes.";
        public const string StrawberryChocolateMochiImageSource = "/Images/strawberry-chocolate-mochi.jpeg";
        public const int StrawberryChocolateMochiCalories = 550;
        public const float StrawberryChocolateMochiPrice = 7.50F;
        public const string StrawberryChocolateMochiQuantity = "4 confections";
        public static readonly List<FoodCategory> StrawberryChocolateMochiCategories = new List<FoodCategory> { FoodCategory.Desserts };
        public static readonly Dictionary<string, List<string>> StrawberryChocolateMochiModifications = new Dictionary<string, List<string>>
        {

        };

        public const string TaiyakiTitle = "Taiyaki";
        public const string TaiyakiDescription = "Japanese fish-shapped cake that contains red bean paste as filling. This paste is made from sweetened azuki beans.";
        public const string TaiyakiImageSource = "/Images/taiyaki.jpg";
        public const int TaiyakiCalories = 220;
        public const float TaiyakiPrice = 3.99F;
        public const string TaiyakiQuantity = "taiyaki";
        public static readonly List<FoodCategory> TaiyakiCategories = new List<FoodCategory> { FoodCategory.Desserts };
        public static readonly Dictionary<string, List<string>> TaiyakiModifications = new Dictionary<string, List<string>>
        {

        };

        public const string CoffeeMilkTeaTitle = "Coffee Milk Tea";
        public const string CoffeeMilkTeaDescription = "Black tea is brewed directly in milk with sugar, then combined with brewed coffee.";
        public const string CoffeeMilkTeaImageSource = "/Images/coffee-milk-tea.jpg";
        public const int CoffeeMilkTeaCalories = 320;
        public const float CoffeeMilkTeaPrice = 5.25F;
        public const string CoffeeMilkTeaQuantity = "drink w/ boba";
        public static readonly List<FoodCategory> CoffeeMilkTeaCategories = new List<FoodCategory> { FoodCategory.Drinks };
        public static readonly Dictionary<string, List<string>> CoffeeMilkTeaModifications = new Dictionary<string, List<string>>
        {
            {
                "Pearls",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Sweetness",
                new List<string>
                {
                    "Less",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Ice",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string GreenTeaTitle = "Green Tea";
        public const string GreenTeaDescription = "Green tea is slightly sweet and leaves a refreshing aftertaste.";
        public const string GreenTeaImageSource = "/Images/green-tea.jpg";
        public const int GreenTeaCalories = 50;
        public const float GreenTeaPrice = 1.99F;
        public const string GreenTeaQuantity = "teapot";
        public static readonly List<FoodCategory> GreenTeaCategories = new List<FoodCategory> { FoodCategory.Drinks };
        public static readonly Dictionary<string, List<string>> GreenTeaModifications = new Dictionary<string, List<string>>
        {
            {
                "Sweetness",
                new List<string>
                {
                    "Less",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Ice",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string HotMatchaLatteTitle = "Hot Matcha Latte";
        public const string HotMatchaLatteDescription = "Tea-based beverage combining vivid green matcha tea powder and milk to create a smooth, creamy latte.";
        public const string HotMatchaLatteImageSource = "/Images/hot-matcha-latte.jpg";
        public const int HotMatchaLatteCalories = 250;
        public const float HotMatchaLattePrice = 3.25F;
        public const string HotMatchaLatteQuantity = "mug";
        public static readonly List<FoodCategory> HotMatchaLatteCategories = new List<FoodCategory> { FoodCategory.Drinks };
        public static readonly Dictionary<string, List<string>> HotMatchaLatteModifications = new Dictionary<string, List<string>>
        {
            {
                "Sweetness",
                new List<string>
                {
                    "Less",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string OriginalMilkTeaTitle = "Original Milk Tea";
        public const string OriginalMilkTeaDescription = "Our signature original milk tea comes with freshly brewed tea and cooked pearls every 2 hours! The tea has a rich flavor that goes perfectly with milk. There is a variety of toppings and sweeteners available.";
        public const string OriginalMilkTeaImageSource = "/Images/original-milk-tea.jpg";
        public const int OriginalMilkTeaCalories = 455;
        public const float OriginalMilkTeaPrice = 5.25F;
        public const string OriginalMilkTeaQuantity = "drink w/ boba";
        public static readonly List<FoodCategory> OriginalMilkTeaCategories = new List<FoodCategory> { FoodCategory.Drinks };
        public static readonly Dictionary<string, List<string>> OriginalMilkTeaModifications = new Dictionary<string, List<string>>
        {
            {
                "Pearls",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Sweetness",
                new List<string>
                {
                    "Less",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Ice",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string RoastedMilkTeaTitle = "Roasted Milk Tea";
        public const string RoastedMilkTeaDescription = "This milk tea uses a special roasted brown sugar to create a sweet, bold, and robust flavor.";
        public const string RoastedMilkTeaImageSource = "/Images/roasted-milk-tea.jpg";
        public const int RoastedMilkTeaCalories = 450;
        public const float RoastedMilkTeaPrice = 5.25F;
        public const string RoastedMilkTeaQuantity = "drink w/ boba";
        public static readonly List<FoodCategory> RoastedMilkTeaCategories = new List<FoodCategory> { FoodCategory.Drinks };
        public static readonly Dictionary<string, List<string>> RoastedMilkTeaModifications = new Dictionary<string, List<string>>
        {
            {
                "Pearls",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Sweetness",
                new List<string>
                {
                    "Less",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Ice",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public const string TaroMilkTeaTitle = "Taro Milk Tea";
        public const string TaroMilkTeaDescription = "The taro milk tea combines jasmine tea with taro flavoring to create a very sweet taste, with a slight hint of vanilla.";
        public const string TaroMilkTeaImageSource = "/Images/taro-milk-tea.jpg";
        public const int TaroMilkTeaCalories = 278;
        public const float TaroMilkTeaPrice = 5.25F;
        public const float TaroMilkTeaDiscount = 1.00F;
        public const string TaroMilkTeaQuantity = "drink w/ boba";
        public static readonly List<FoodCategory> TaroMilkTeaCategories = new List<FoodCategory> { FoodCategory.Specials, FoodCategory.Drinks };
        public static readonly Dictionary<string, List<string>> TaroMilkTeaModifications = new Dictionary<string, List<string>>
        {
            {
                "Pearls",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Sweetness",
                new List<string>
                {
                    "Less",
                    "Normal",
                    "Extra"
                }
            },
            {
                "Ice",
                new List<string>
                {
                    "None",
                    "Normal",
                    "Extra"
                }
            }
        };

        public static List<FoodItem> GetFoodItemList()
        {
            return new List<FoodItem>
            {
                new FoodItem
                {
                    Title = SpicyRamenTitle,
                    Description = SpicyRamenDescription,
                    ImageSource = new BitmapImage( new Uri( SpicyRamenImageSource, UriKind.Relative ) ),
                    Calories = SpicyRamenCalories,
                    Price = SpicyRamenPrice,
                    Discount = SpicyRamenDiscount,
                    Quantity = SpicyRamenQuantity,
                    Categories = SpicyRamenCategories,
                    Modifications = SpicyRamenModifications
                },
                new FoodItem
                {
                    Title = TempuraTitle,
                    Description = TempuraDescription,
                    ImageSource = new BitmapImage( new Uri( TempuraImageSource, UriKind.Relative ) ),
                    Calories = TempuraCalories,
                    Price = TempuraPrice,
                    Discount = TempuraDiscount,
                    Quantity = TempuraQuantity,
                    Categories = TempuraCategories,
                    Modifications = TempuraModifications
                },
                new FoodItem
                {
                    Title = MisoRamenTitle,
                    Description = MisoRamenDescription,
                    ImageSource = new BitmapImage( new Uri( MisoRamenImageSource, UriKind.Relative ) ),
                    Calories = MisoRamenCalories,
                    Price = MisoRamenPrice,
                    Quantity = MisoRamenQuantity,
                    Categories = MisoRamenCategories,
                    Modifications = MisoRamenModifications
                },
                new FoodItem
                {
                    Title = CaliforniaRollTitle,
                    Description = CaliforniaRollDescription,
                    ImageSource = new BitmapImage( new Uri( CaliforniaRollImageSource, UriKind.Relative ) ),
                    Calories = CaliforniaRollCalories,
                    Price = CaliforniaRollPrice,
                    Quantity = CaliforniaRollQuantity,
                    Categories = CaliforniaRollCategories,
                    Modifications = CaliforniaRollModifications
                },
                new FoodItem
                {
                    Title = TunaRollTitle,
                    Description = TunaRollDescription,
                    ImageSource = new BitmapImage( new Uri( TunaRollImageSource, UriKind.Relative ) ),
                    Calories = TunaRollCalories,
                    Price = TunaRollPrice,
                    Quantity = TunaRollQuantity,
                    Categories = TunaRollCategories,
                    Modifications = TunaRollModifications
                },
                new FoodItem
                {
                    Title = SalmonSushiRollTitle,
                    Description = SalmonSushiRollDescription,
                    ImageSource = new BitmapImage( new Uri( SalmonSushiRollImageSource, UriKind.Relative ) ),
                    Calories = SalmonSushiRollCalories,
                    Price = SalmonSushiRollPrice,
                    Quantity = SalmonSushiRollQuantity,
                    Categories = SalmonSushiRollCategories,
                    Modifications = SalmonSushiRollModifications
                },
                new FoodItem
                {
                    Title = SalmonSushiTitle,
                    Description = SalmonSushiDescription,
                    ImageSource = new BitmapImage( new Uri( SalmonSushiImageSource, UriKind.Relative ) ),
                    Calories = SalmonSushiCalories,
                    Price = SalmonSushiPrice,
                    Quantity = SalmonSushiQuantity,
                    Categories = SalmonSushiCategories,
                    Modifications = SalmonSushiModifications
                },
                new FoodItem
                {
                    Title = AgedashiTofuWithBrothTitle,
                    Description = AgedashiTofuWithBrothDescription,
                    ImageSource = new BitmapImage( new Uri( AgedashiTofuWithBrothImageSource, UriKind.Relative ) ),
                    Calories = AgedashiTofuWithBrothCalories,
                    Price = AgedashiTofuWithBrothPrice,
                    Quantity = AgedashiTofuWithBrothQuantity,
                    Categories = AgedashiTofuWithBrothCategories,
                    Modifications = AgedashiTofuWithBrothModifications
                },
                new FoodItem
                {
                    Title = JapanesePancakesTitle,
                    Description = JapanesePancakesDescription,
                    ImageSource = new BitmapImage( new Uri( JapanesePancakesImageSource, UriKind.Relative ) ),
                    Calories = JapanesePancakesCalories,
                    Price = JapanesePancakesPrice,
                    Quantity = JapanesePancakesQuantity,
                    Categories = JapanesePancakesCategories,
                    Modifications = JapanesePancakesModifications
                },
                new FoodItem
                {
                    Title = KaraageTitle,
                    Description = KaraageDescription,
                    ImageSource = new BitmapImage( new Uri( KaraageImageSource, UriKind.Relative ) ),
                    Calories = KaraageCalories,
                    Price = KaraagePrice,
                    Quantity = KaraageQuantity,
                    Categories = KaraageCategories,
                    Modifications = KaraageModifications
                },
                new FoodItem
                {
                    Title = GreenTeaIceCreamTitle,
                    Description = GreenTeaIceCreamDescription,
                    ImageSource = new BitmapImage( new Uri( GreenTeaIceCreamImageSource, UriKind.Relative ) ),
                    Calories = GreenTeaCalories,
                    Price = GreenTeaIceCreamPrice,
                    Quantity = GreenTeaIceCreamQuantity,
                    Categories = GreenTeaIceCreamCategories,
                    Modifications = GreenTeaIceCreamModifications
                },
                new FoodItem
                {
                    Title = IceCreamMochiTitle,
                    Description = IceCreamMochiDescription,
                    ImageSource = new BitmapImage( new Uri( IceCreamMochiImageSource, UriKind.Relative ) ),
                    Calories = IceCreamMochiCalories,
                    Price = IceCreamMochiPrice,
                    Quantity = IceCreamMochiQuantity,
                    Categories = IceCreamMochiCategories,
                    Modifications = IceCreamMochiModifications
                },
                new FoodItem
                {
                    Title = StrawberryChocolateMochiTitle,
                    Description = StrawberryChocolateMochiDescription,
                    ImageSource = new BitmapImage( new Uri( StrawberryChocolateMochiImageSource, UriKind.Relative ) ),
                    Calories = StrawberryChocolateMochiCalories,
                    Price = StrawberryChocolateMochiPrice,
                    Quantity = StrawberryChocolateMochiQuantity,
                    Categories = StrawberryChocolateMochiCategories,
                    Modifications = StrawberryChocolateMochiModifications
                },
                new FoodItem
                {
                    Title = TaiyakiTitle,
                    Description = TaiyakiDescription,
                    ImageSource = new BitmapImage( new Uri( TaiyakiImageSource, UriKind.Relative ) ),
                    Calories = TaiyakiCalories,
                    Price = TaiyakiPrice,
                    Quantity = TaiyakiQuantity,
                    Categories = TaiyakiCategories,
                    Modifications = TaiyakiModifications
                },
                new FoodItem
                {
                    Title = CoffeeMilkTeaTitle,
                    Description = CoffeeMilkTeaDescription,
                    ImageSource = new BitmapImage( new Uri( CoffeeMilkTeaImageSource, UriKind.Relative ) ),
                    Calories = CoffeeMilkTeaCalories,
                    Price = CoffeeMilkTeaPrice,
                    Quantity = CoffeeMilkTeaQuantity,
                    Categories = CoffeeMilkTeaCategories,
                    Modifications = CoffeeMilkTeaModifications
                },
                new FoodItem
                {
                    Title = GreenTeaTitle,
                    Description = GreenTeaDescription,
                    ImageSource = new BitmapImage( new Uri( GreenTeaImageSource, UriKind.Relative ) ),
                    Calories = GreenTeaCalories,
                    Price = GreenTeaPrice,
                    Quantity = GreenTeaQuantity,
                    Categories = GreenTeaCategories,
                    Modifications = GreenTeaModifications
                },
                new FoodItem
                {
                    Title = HotMatchaLatteTitle,
                    Description = HotMatchaLatteDescription,
                    ImageSource = new BitmapImage( new Uri( HotMatchaLatteImageSource, UriKind.Relative ) ),
                    Calories = HotMatchaLatteCalories,
                    Price = HotMatchaLattePrice,
                    Quantity = HotMatchaLatteQuantity,
                    Categories = HotMatchaLatteCategories,
                    Modifications = HotMatchaLatteModifications
                },
                new FoodItem
                {
                    Title = OriginalMilkTeaTitle,
                    Description = OriginalMilkTeaDescription,
                    ImageSource = new BitmapImage( new Uri( OriginalMilkTeaImageSource, UriKind.Relative ) ),
                    Calories = OriginalMilkTeaCalories,
                    Price = OriginalMilkTeaPrice,
                    Quantity = OriginalMilkTeaQuantity,
                    Categories = OriginalMilkTeaCategories,
                    Modifications = OriginalMilkTeaModifications
                },
                new FoodItem
                {
                    Title = RoastedMilkTeaTitle,
                    Description = RoastedMilkTeaDescription,
                    ImageSource = new BitmapImage( new Uri( RoastedMilkTeaImageSource, UriKind.Relative ) ),
                    Calories = RoastedMilkTeaCalories,
                    Price = RoastedMilkTeaPrice,
                    Quantity = RoastedMilkTeaQuantity,
                    Categories = RoastedMilkTeaCategories,
                    Modifications = RoastedMilkTeaModifications
                },
                new FoodItem
                {
                    Title = TaroMilkTeaTitle,
                    Description = TaroMilkTeaDescription,
                    ImageSource = new BitmapImage( new Uri( TaroMilkTeaImageSource, UriKind.Relative ) ),
                    Calories = TaroMilkTeaCalories,
                    Price = TaroMilkTeaPrice,
                    Discount = TaroMilkTeaDiscount,
                    Quantity = TaroMilkTeaQuantity,
                    Categories = TaroMilkTeaCategories,
                    Modifications = TaroMilkTeaModifications
                }
            };
        }
    }
}
