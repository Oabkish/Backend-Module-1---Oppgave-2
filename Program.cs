Console.WriteLine("What is your name?");
string name = Console.ReadLine();

bool nameisinput = !string.IsNullOrEmpty(name);

if (nameisinput)
{
    int time= DateTime.Now.Hour;
    if (time>= 6 && time < 11)
    {
        Console.WriteLine($"Good Morning "+ name);
    }
    else if (time>= 11 && time < 18)
    {
         Console.WriteLine($"Good Day "+ name);
    }
    else
    {
         Console.WriteLine($"Good Night "+ name);
    }

}
else {
Console.WriteLine ("Please enter your name again");
name = Console.ReadLine();
}

