Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // thing that we are talking about
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); /* description of the thing */
string c = "of Doom"; // where it came from
string d = "3000"; // the version of the thing
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");

// we could make the name of the variables more descriptive