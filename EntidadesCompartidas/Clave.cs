using System;
using System.Security.Cryptography;

namespace EntidadesCompartidas
{
    public class Clave
    {
        public Clave()
        {

        }
        private static readonly Random random = new Random();
        ////Esta función es para encriptar la clave al REGISTRARSE recibe el String de la clave que introduce el usuario 
        public static string encriptarClaveRegistro(string PassUser)
        {
            int minSaltSize = 4;
            int maxSaltSize = 8;

            // determina el tamaño de la sal
            int saltSize = random.Next(minSaltSize, maxSaltSize);
            byte[] saltBytes = new byte[saltSize];

            // Utiliza un generador seguro de números aleatorios
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Obtiene la sal con el generador
            rng.GetNonZeroBytes(saltBytes);


            // Convierte la contraseña a array de bytes
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(PassUser);

            // Array para guardar la contraseña y la sal
            byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];

            // Almacena la contraseña
            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainTextBytes[i];
            }

            // Añade la sal
            for (int i = 0; i < saltBytes.Length; i++)
            {
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
            }

            // Especifica el algoritmo SHA512
            HashAlgorithm hash = new SHA512Managed();

            // Calcula el hash
            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            // Array para almacenar el hash y la sal
            byte[] hashWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

            // Copia el hash en el Array
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashWithSaltBytes[i] = hashBytes[i];
            }

            // Añade la sal
            for (int i = 0; i < saltBytes.Length; i++)
            {
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
            }

            // Convierte el resultado a cadena y lo devuelve
            return Convert.ToBase64String(hashWithSaltBytes);
        }

        //Esta función es para encriptar la clave al LOGUEARSE
        public static string encriptarClaveConexion(string PassUser, string sal)
        {
            // Convierte la sal en array de bytes
            byte[] saltBytes = Convert.FromBase64String(sal);

            // Convierte la contraseña a array de bytes
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(PassUser);

            // Array para guardar la contraseña y la sal
            byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];

            // Almacena la contraseña
            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainTextBytes[i];
            }

            // Añade la sal
            for (int i = 0; i < saltBytes.Length; i++)
            {
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
            }

            // Especifica el algoritmo SHA512
            HashAlgorithm hash = new SHA512Managed();

            // Calcula el hash
            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            // Array para almacenar el hash y la sal
            byte[] hashWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

            // Copia el hash en el array
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashWithSaltBytes[i] = hashBytes[i];
            }

            // Añade la sal
            for (int i = 0; i < saltBytes.Length; i++)
            {
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
            }

            // Convierte el resultado a cadena y lo devuelve
            return Convert.ToBase64String(hashWithSaltBytes);
        }

        //Coge la Clave encriptada y extrae la "sal" y la retorna
        public static string getSal(string hash)
        {
            // Convierte al hash a Array de bytes
            byte[] hashWithSaltBytes = Convert.FromBase64String(hash);

            // Tamaño del hash en bits
            int hashSizeInBits, hashSizeInBytes;
            hashSizeInBits = 512;

            // Convierte el tamaño a bytes
            hashSizeInBytes = hashSizeInBits / 8;

            // Verifica que el valor es lo suficientemente largo
            if (hashWithSaltBytes.Length < hashSizeInBytes)
                return null;

            // Array para almacenar la sal
            byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

            // Copia la sal al array
            for (int i = 0; i < saltBytes.Length; i++)
            {
                saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
            }

            return Convert.ToBase64String(saltBytes);

            //return saltBytes;
        }

        public static bool validarClave(string pass, string hash)
        {
            if (pass.Equals(hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}