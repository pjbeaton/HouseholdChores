using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.IO.IsolatedStorage;

namespace SogetiBattlecard.Data
{
    public class IsolatedStorageHelper
    {
        #region "Public Methods"

        public static string Encrypt(string dataToEncrypt, string password, string salt)
        {
            AesManaged aes = null;
            MemoryStream memoryStream = null;
            CryptoStream cryptoStream = null; 
            
            try
            {
                // Generate a Key based on a Password and HMACSHA1 pseudo-random number generator.
                // Salt must be at least 8 bytes long.
                // Use an iteration count of at least 1000.
                Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 10000);

                // Create AES algorithm.
                aes = new AesManaged();
                // Key derived from byte array with 32 pseudo-random key bytes.
                aes.Key = rfc2898.GetBytes(32);
                // IV derived from byte array with 16 pseudo-random key bytes.
                aes.IV = rfc2898.GetBytes(16);

                // Create Memory and Crypto Streams.
                memoryStream = new MemoryStream();
                cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

                // Encrypt Data.
                byte[] data = Encoding.UTF8.GetBytes(dataToEncrypt);
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                // Return Base 64 String.
                return Convert.ToBase64String(memoryStream.ToArray());
            }
            finally
            {
                if (cryptoStream != null)
                    cryptoStream.Close();

                if (memoryStream != null)
                    memoryStream.Close();

                if (aes != null)
                    aes.Clear();
            }
        }

        public static string Decrypt(string dataToDecrypt, string password, string salt)
        {
            AesManaged aes = null;
            MemoryStream memoryStream = null;

            try
            {
                // Generate a Key based on a Password and HMACSHA1 pseudo-random number generator.
                // Salt must be at least 8 bytes long.
                // Use an iteration count of at least 1000.
                Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 10000);

                //  Create AES algorithm.
                aes = new AesManaged();

                //  Key derived from byte array with 32 pseudo-random key bytes.
                aes.Key = rfc2898.GetBytes(32);
                // IV derived from byte array with 16 pseudo-random key bytes.
                aes.IV = rfc2898.GetBytes(16);

                // Create Memory and Crypto Streams.
                memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

                // Decrypt Data.
                byte[] data = Convert.FromBase64String(dataToDecrypt);
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                // Return Decrypted String.
                byte[] decryptBytes = memoryStream.ToArray();

                // Dispose.
                if (cryptoStream != null)
                    cryptoStream.Dispose();

                // Retval.
                return Encoding.UTF8.GetString(decryptBytes, 0, decryptBytes.Length);
            }
            finally
            {
                if (memoryStream != null)
                    memoryStream.Dispose();

                if (aes != null)
                    aes.Clear();
            }
        }

        public static void SaveState(string Name, string Value)
        {
            try
            {
                if (IsolatedStorageSettings.ApplicationSettings.Contains(Name))
                {
                    IsolatedStorageSettings.ApplicationSettings[Name] = Value;
                }
                else
                {
                    IsolatedStorageSettings.ApplicationSettings.Add(Name, Value);
                }
            }
            catch (Exception e)
            { }
        }

        public static string LoadState(string Name)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(Name) && IsolatedStorageSettings.ApplicationSettings[Name] != null)
            {
                return IsolatedStorageSettings.ApplicationSettings[Name].ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion
    }
}
