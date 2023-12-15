WriteLine("hellO");
//using Crypto.Cryptography;
//using static System.Net.Mime.MediaTypeNames;


//string pathKey = Path.Combine(Environment.CurrentDirectory, "key.txt");
//string emptyTextMessage = "Text is empty, did you forget to fill out the input.txt file?";  

//string instructions = """
//    Enter your encrypted/decrypted text, into the input.txt file.
//    Enter your encryption key when prompted.
//    Tell the application whether you want to encrypt or decrypt the text.
//    """;
//WriteLine(instructions);

//bool validInput = false;
//while (!validInput)
//{
//    try
//    {
//        WriteLine("Enter your encryption key: ");
//        string? key = ReadLine();
//        WriteLine();
//        if (key == null)
//        {
//            WriteLine("Invalid input, did not enter a key.");
//        }
//        WriteLine("Do you want to [E]ncrypt or [D]ecrypt? (E/D)");
//        ConsoleKey ck = Console.ReadKey().Key;
//        WriteLine();
//        switch (ck)
//        {
//            case ConsoleKey.E:
//                Encrypt(key);
//                WriteLine("Text encrypted successfully!");
//                validInput = true;
//                break;
//            case ConsoleKey.D:
//                Decrypt(key);
//                WriteLine("Text decrypted successfully!");
//                validInput = true;
//                break;
//            default:
//                WriteLine("Invalid input");
//                break;
//        }
//        WriteLine("Find your encrypted/decrypted text in the output.txt file.");
//        WriteText(key, pathKey);
//        WriteLine("Your key was copied to key.txt in case you forget.");
//        WriteLine("Press any key to exit.");
//        ReadKey();

//    }
//    catch (Exception ex)
//    {
//        WriteLine(ex.Message);
//    }
//}

//void Decrypt(string key)
//{
//    string text = ReadText();
//    if (text == null || text.Length == 0) throw new ArgumentException(emptyTextMessage);
//    string decryptedText = Cryptographer.Decrypt(text, key);
//    WriteText(decryptedText, pathOutput);

//}

//void Encrypt(string? key)
//{
//    string text = ReadText();
//    if (text == null || text.Length == 0) throw new ArgumentException(emptyTextMessage);
//    string encryptedText = Cryptographer.Encrypt(text, key);
//    WriteText(encryptedText, pathOutput);
//}

//string ReadText()
//{
//    using (StreamReader sr = new StreamReader(pathInput))
//    {
//        string? text = sr.ReadToEnd();
//        return text;
//    }
//}
//void WriteText(string decryptedText, string path)
//{
//    using (StreamWriter sw = new StreamWriter(path))
//    {
//        sw.Write(decryptedText);
//    }
//}
