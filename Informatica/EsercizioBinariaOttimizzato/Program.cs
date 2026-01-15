namespace EsercizioBinariaOttimizzato;

class Program
{
    static void Main(string[] args)
    {
        static byte[] convertToBinary(int number)
        {
            byte[] binary = new byte[32];
            int i = 31;

            while(number > 0)
            {
                byte digit = (byte)(number % 2);
                binary[i] = digit;
                number = number / 2;
                i--;
            }
            
            return binary;
        }

        int number = int.Parse(Console.ReadLine()!);
        byte[] result = convertToBinary(number);
        int j = 0;
        for (int i = 0; i < result.Length; i++)
        {
            j++;
            Console.Write(result[i]);
            if (j >= 4)
            {
                Console.Write(" ");
                j = 0;
            }
        }
        
    }
}