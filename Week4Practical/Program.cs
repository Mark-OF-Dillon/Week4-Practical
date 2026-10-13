Console.WriteLine("Hello, World! \n");


//Challenge 1//

//Creates an array called carManufacturers
String[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda" };

//Prints each item in the carManufacturers array
foreach (String brand in carManufacturers)
{
    Console.WriteLine(brand);
}

//Sorts the items in the carManufacturers array alphabetically
Array.Sort(carManufacturers);
foreach (String brand in carManufacturers)
{
    Console.WriteLine(brand);
}

//for (int carIndex = 0; carIndex < carManufacturers.Length;)
//{
//    Console.WriteLine("Brand");
//}


//Challenge 2//

//Creates String List
List<String> months = new List<String>();

//Adds items to the months list
months.Add("Janurary");
months.Add("Feburary");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");

//Counts the itmes in the months list
Console.WriteLine($"\n There are {months.Count} items in the Months list");

//Removes items from the  months list
months.Remove("September");
months.Remove("November");

Console.WriteLine($"\n There are {months.Count} items in the Months list");

//Finds the index of an item in the months list
Console.WriteLine($"\n The selected item is of index {months.IndexOf("December")}");

//Converts the months list to an array
String[] monthNamesArray = months.ToArray();

Console.WriteLine("\n The months list is now an Array");


//Challenge 3//

//Creates a dictionary called inventory
Dictionary<String, int> inventory =  new Dictionary<String, int>();

//Adds items into the inventory dictionary
inventory.Add("Health Potion", 5);
inventory.Add("Mana Potion", 2);
inventory.Add("Gold Coin", 100);

//Prints each item in the inventory dictionary
foreach (var entry in inventory)
{
    Console.WriteLine($"Item: {entry.Key}, Quantity: {entry.Value}");
}

//Override a value in inventory dictionary
