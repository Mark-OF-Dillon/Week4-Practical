Console.WriteLine("Hello, World! \n");

//Challenge 1//
String[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda" };
foreach (String brand in carManufacturers)
{
    Console.WriteLine(brand);
}

Array.Sort(carManufacturers);
foreach (String brand in carManufacturers)
{
    Console.WriteLine(brand);
}

//for (int carIndex = 0; carIndex < carManufacturers.Length;)
//{
//    Console.WriteLine("Brand");
//}

