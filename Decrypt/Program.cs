using IO.Library;
using Cryptography.Library;

BaseIOCryptoManager ioManager = new BaseIOCryptoManager();
string? text = Reader.ReadText(ioManager.PathInput);
string? key = Reader.ReadText(ioManager.PathKey);
string? plainText = Cryptographer.Decrypt(text, key);
Writer.WriteText(plainText, ioManager.PathOutput);

