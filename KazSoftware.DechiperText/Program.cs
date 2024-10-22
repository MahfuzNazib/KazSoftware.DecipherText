using System.Text;

namespace KazSoftware.DecipherText
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cipherText = "UHV0IHRoZSBzdWJqZWN0IG9mIHRoZSBlbWFpbDogQyMgaXMgdGhlIGJlc3Qg";
            string decodedText = DecipherText(cipherText);

            Console.WriteLine($"Decoded By Nazib. Decoded Text : {decodedText}");
        }

        public static string DecipherText(string encodedText)
        {
            byte[] bytes = Convert.FromBase64String(encodedText);
            string decodedText = Encoding.UTF8.GetString(bytes);

            return decodedText;
        }
    }
}
