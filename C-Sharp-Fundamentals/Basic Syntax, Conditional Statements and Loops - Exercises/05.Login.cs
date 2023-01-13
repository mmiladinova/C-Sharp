string username = Console.ReadLine();

string password = "";
int counter = 1;

for (int i = username.Length - 1; i >= 0; i--)
{
    password += username[i];
}

while (counter <= 4)
{
    string inpPass = Console.ReadLine();
    if (counter == 4)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }

    if (password == inpPass)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else
    {
        Console.WriteLine("Incorrect password. Try again.");
        counter++;
    }
}


