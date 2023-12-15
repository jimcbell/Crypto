string instructions = """
    Enter your encrypted/decrypted text, into the input.txt file.
    Enter your 8 byte encryption key when prompted.
    Tell the application whether you want to encrypt or decrypt the text.
    """;
WriteLine(instructions);

bool invalidInput = false;
while (!invalidInput)
{
    try
    {
        WriteLine("Enter your 8 byte encryption key: ");
        string key = ReadLine();
        WriteLine("Do you want to [E]ncrypt or [D]ecrypt? (E/D)");
        ConsoleKey ck = Console.ReadKey().Key;
        switch (ck)
        {
            case ConsoleKey.E:
                Encrypt(key);
                break;
            case ConsoleKey.D:
                Decrypt(key);
                break;
            default:
                WriteLine("Invalid input");
                break;
        }
        WriteLine("Find your encrypted/decrypted text in the output.txt file.");
        WriteLine("Press any key to exit.");
        ReadKey();

    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
        invalidInput = true;
    }
}


string path = Path.Combine(Environment.CurrentDirectory, "input.txt");
using (StreamReader sr = new)