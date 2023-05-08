// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Lączenie ciągu string za pomocą + oraz Interpolacja ciągów przed
// ciągiem Console.WriteLine($ "{nazwa stringów}");
//
string name = "Hello" +"Grzegorz";
Console.WriteLine(name);
string name1 = "Cześć" + "Grzegorz";
Console.WriteLine(name1);
Console.WriteLine($"Cześć{name1}!");
Console.WriteLine($"Cześć{name}");

string surname = "Mikałasz";
string nameHello = "hello";

Console.WriteLine($"hello{nameHello}");
Console.WriteLine($"hello{surname}");
//
//Automatyczne obliczanie długości łańcucha wywołanie Length
//
string myName = "Grzegorz";
string friendName = "Kukuczka";

Console.WriteLine($"The name{ myName} has {myName.Length} letters.");//dł. ciągu
Console.WriteLine($"The name {friendName} has {friendName.Length} letters.");//dł. ciągu
// Znalezienie i zamiana zdań, wyrazów w ciągu

string hello = "Hej Ekipa!";
//Console.WriteLine(hello)
 hello = hello.Replace("Hej","Czołem");

Console.WriteLine(hello);

// znalezienie określonego ciągu za pomocą wywołania Contains
// metoda informuje czy dany ciąg zawiera dany podciąg

string hello1 = "Hej Ekipa1!";
Console.WriteLine(hello1.Contains("Hej"));
Console.WriteLine(hello.Contains("Cześć"));
// Metoda Contains zwraca wartości bool (true i false), która informuje, czy szukany 
// ciąg został odnaleziony.
//
//            Zadanie#2
//
string name2 = "Hej Ekipa z Kursu 8k.";

Console.WriteLine(name2.StartsWith("Hej"));
Console.WriteLine(name2.StartsWith("Cześć"));
Console.WriteLine(name2.StartsWith("8k."));
Console.WriteLine(name2.EndsWith("Hej"));
Console.WriteLine(name2.EndsWith("8k."));
Console.WriteLine(name2.EndsWith("Kursu"));











