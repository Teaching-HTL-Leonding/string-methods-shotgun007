char searched = 'a';
int index = 0;
int length = 0;
int numberofremovechars = 0;

string selection = "a";
do
{
    Console.Clear();
    Console.WriteLine("Enter a string!");
    string input = Console.ReadLine()!;
    
    Console.WriteLine("What do you want to execute?");
    Console.WriteLine("============================");
    Console.WriteLine();
    Console.WriteLine("0. Contains");
    Console.WriteLine("1. IndexOf");
    Console.WriteLine("2. LastIndexOf");
    Console.WriteLine("3. TrimStart");
    Console.WriteLine("4. TrimEnd");
    Console.WriteLine("5. Trim");
    Console.WriteLine("6. SubString");
    Console.WriteLine("7. Remove");
    Console.WriteLine("empty string to Quit");
    selection = Console.ReadLine()!;

    if (selection == "0" || selection == "1" || selection == "2" || selection == "3" || selection == "4" || selection == "5")
    {
        Console.WriteLine("Enter a char");
        searched = char.Parse(Console.ReadLine()!);
    }
    else if (selection == "6" || selection == "7")
    {
        Console.WriteLine("Enter the index");
        index = int.Parse(Console.ReadLine()!);
    }
    if (selection == "6")
    {
        Console.WriteLine("Enter the length of the SubString");
        length = int.Parse(Console.ReadLine()!);
    }
    else if (selection == "7")
    {
        Console.WriteLine("How many numbers do you want to remove?");
        numberofremovechars = int.Parse(Console.ReadLine()!);
    }
    if (selection != "q")
    {
        Console.Clear();
        switch (selection)
        {
            case "0": Contains(input, searched); break;
            case "1": IndexOf(input, searched); break;
            case "2": LastIndexOf(input, searched); break;
            case "3": TrimStart(input, searched); break;
            case "4": TrimEnd(input, searched); break;
            case "5": Trim(input, searched); break;
            case "6": SubString(input, index, length); break;
            case "7": Remove(input, index, numberofremovechars); break;
            default: break;
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
while (selection != "");

void Contains(string input, char searched)
{

    bool solution = false;
    bool end = false;
    for (int i = 0; i < input.Length && end == false; i++)
    {
        int a = input[i];
        if (a == searched)
        {
            solution = true;
            end = true;
        }
    }
    Console.Write("Contains:");
    Console.Write(" ");
    Console.WriteLine(solution);
}
void IndexOf(string input, char searched)
{

    int memory = -1;
    bool end = false;
    for (int i = 0; i < input.Length && end == false; i++)
    {
        int a = input[i];
        if (a == searched)
        {
            memory = i;
            end = true;
        }
    }
    Console.Write("IndexOf:");
    Console.Write(" ");
    Console.WriteLine(memory);
}
void LastIndexOf(string input, char searched)
{

    int memory = -1;
    for (int i = 0; i < input.Length; i++)
    {
        int a = input[i];
        if (a == searched)
        {
            memory = i;
        }
    }
    Console.Write("LastIndexOf:");
    Console.Write(" ");
    Console.WriteLine(memory);
}
void TrimStart(string input, char searched)
{
    int i = 0;
    int memory = -1;
    bool end = false;
    for (; i < input.Length && end == false; i++)
    {
        int a = input[i];
        if (a == searched)
        {
            memory = i;
        }
        else
        {
            end = true;
            i--;
        }
    }
    string newinput = input[i..];
    Console.Write("TrimStart:");
    Console.Write(" ");
    Console.WriteLine(newinput);
}
void TrimEnd(string input, char searched)
{
    int i = 0;
    int memory = 0;
    for (; i < input.Length; i++)
    {
        int a = input[i];
        if (a == searched)
        {
            memory++;
        }
        else if (a != searched)
        {
            memory = 0;
        }
    }
    int index = input.Length - memory;
    string newinput = input[..index];
    Console.Write("TrimEnd:");
    Console.Write(" ");
    Console.WriteLine(newinput);
}
void Trim(string input, char searched)
{
    int i = 0;
    int memory = 0;

    for (; i < input.Length; i++)
    {
        int a = input[i];
        if (a == searched)
        {
            memory++;
        }
        else if (a != searched)
        {
            memory = 0;
        }
    }
    int index = input.Length - memory;
    int j = 0;
    bool end = false;
    for (; j < input.Length && end == false; j++)
    {
        int a = input[j];
        if (a == searched)
        {
            memory = j;
        }
        else
        {
            end = true;
            j--;
        }
    }
    string newinput = input[..index];
    string newnewinput = newinput[j..];
    Console.Write("Trim:");
    Console.Write(" ");
    Console.WriteLine(newnewinput);
}
void SubString(string input, int index, int length)
{
    int i = index;
    string newinput = input[i..];
    i = i + length - 2;
    if (newinput.Length < i)
    {
        i = newinput.Length;
    }
    string newnewinput = newinput[..i];
    Console.Write("SubString:");
    Console.Write(" ");
    Console.WriteLine(newnewinput);
}
void Remove(string input, int index, int numberofremovechars)
{
    string newnewinput = "";
    int i = index;
    string newinput = input[..i];
    i = i + numberofremovechars;
    if (i < input.Length)
    {
        newnewinput = input[i..];
    }
    Console.Write("Remove:");
    Console.Write(" ");
    Console.WriteLine(newinput + newnewinput);
}
