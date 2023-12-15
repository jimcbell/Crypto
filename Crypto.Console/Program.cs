using Crypto.Cryptography;
using static System.Net.Mime.MediaTypeNames;

string pathInput = Path.Combine(Environment.CurrentDirectory, "input.txt");
string pathOutput = Path.Combine(Environment.CurrentDirectory, "output.txt");
string emptyTextMessage = "Text is empty, did you forget to fill out the input.txt file?";  

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
        string? key = ReadLine();
        if (key == null)
        {
            invalidInput = true;
            WriteLine("Invalid input, did not enter a key.");
        }
        WriteLine("Do you want to [E]ncrypt or [D]ecrypt? (E/D)");
        ConsoleKey ck = Console.ReadKey().Key;
        switch (ck)
        {
            case ConsoleKey.E:
                Encrypt(key);
                WriteLine("Text encrypted successfully!");
                break;
            case ConsoleKey.D:
                Decrypt(key);
                WriteLine("Text decrypted successfully!");
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

void Decrypt(string key)
{
    string text = ReadText();
    if (text == null || text.Length == 0) throw new ArgumentException(emptyTextMessage);
    string decryptedText = Cryptographer.Decrypt(text, key);
    WriteText(decryptedText);

}

void Encrypt(string? key)
{
    string text = ReadText();
    if (text == null || text.Length == 0) throw new ArgumentException(emptyTextMessage);
    string encryptedText = Cryptographer.Encrypt(text, key);
    WriteText(encryptedText);
}

string ReadText()
{
    using (StreamReader sr = new StreamReader(pathInput))
    {
        string? text = sr.ReadToEnd();
        return text;
    }
}
void WriteText(string decryptedText)
{
    using (StreamWriter sw = new StreamWriter(pathOutput))
    {
        sw.Write(decryptedText);
    }
}
