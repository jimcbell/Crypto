using Cryptography.Library;
using IO.Library;

BaseIOCryptoManager ioManager = new BaseIOCryptoManager();
string? text = Reader.ReadText(ioManager.PathInput);
string? key = Reader.ReadText(ioManager.PathKey);
string? encryptedText = Cryptographer.Encrypt(text, key);
Writer.WriteText(encryptedText, ioManager.PathOutput);



