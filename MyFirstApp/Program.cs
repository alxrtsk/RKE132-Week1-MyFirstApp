// This is a commentary for the code

// App asks the user's name
// App greets user by it's name

Console.WriteLine("Enter your name:"); //output
//string=sõne
string userName = Console.ReadLine(); //input

Console.WriteLine("Hello" + ", " +  userName + "!");

//string interpolation
Console.WriteLine($"Hello, {userName} !");
