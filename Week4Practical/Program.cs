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


//Challenge 2//

//Create String List
List<String> months = new List<String>();

//Adding items to the months list
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

//Counting the itmes in the months list
Console.WriteLine($"\n There are {months.Count} items in the Months list");

//Removeing items from the  months list
months.Remove("September");
months.Remove("November");

Console.WriteLine($"\n There are {months.Count} items in the Months list");

//Finding the index of an item in the months list
Console.WriteLine($"\n The selected item is of index {months.IndexOf("December")}");

//Converting the months list to an array
String[] monthNamesArray = months.ToArray();

Console.WriteLine("\n The months list is now an Array");