using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace One_Time_pad
{
    class Program
    {
        static void Encryption()
        {
            Console.Write("-------------------------------------------------------" +
                "\n* Enter your data: ");

            string enDataNoReg = Console.ReadLine().ToUpper();
            string numericDataNoReg = LitterToNum(enDataNoReg);
            Console.WriteLine("* You data in numeric is: {0}\n* And length to your key is: {1} !!!", numericDataNoReg, numericDataNoReg.Length);
            int[] masEnycrOne = NumericValueOne(numericDataNoReg);

            Console.Write("* Enter your key: ");
            string enKeyDataNoReg = Console.ReadLine();
            int[] masKeyOne = NumericValueOne(enKeyDataNoReg);

            if (masEnycrOne.Length != masKeyOne.Length)
            {
                Console.WriteLine("* Your key no valid!");
            }
            else
            {
                int[] resultMasEncr = new int[masEnycrOne.Length];
                int numeric = 0;

                for (int i = 0; i < masEnycrOne.Length; i++)
                {
                    if (masEnycrOne[i] < masKeyOne[i] || masEnycrOne[i] > masKeyOne[i] || masEnycrOne[i] == masKeyOne[i])
                    {
                        numeric = (masEnycrOne[i] + masKeyOne[i]) % 10;
                        resultMasEncr[i] = numeric;
                    }
                    else
                    {
                        numeric = masEnycrOne[i] + masKeyOne[i];
                        resultMasEncr[i] = numeric;
                    }
                }

                string resultDataEncr = string.Join(null, resultMasEncr);
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("* Your encrypted data: {0}", resultDataEncr);
            }
        }

        static int[] NumericValueOne(string giveData)
        {
            int counGivData = giveData.Length;
            char[] dataToMassOne = giveData.ToCharArray();
            int[] dataMassive = new int[counGivData];

            for (int i = 0; i < counGivData; i++)
            {
                dataMassive[i] = (int)Char.GetNumericValue(dataToMassOne[i]);
            }

            return dataMassive;
        }

        static string LitterToNum(string noRegDataValue)
        {
            string[] litteralStrMass = new string[noRegDataValue.Length];

            Console.Write("\n[");

            for (int i = 0; i < noRegDataValue.Length; i++)
            {
                litteralStrMass[i] = noRegDataValue[i].ToString();

                Thread.Sleep(50);

                if (litteralStrMass[i] == "A")
                {
                    litteralStrMass[i] = "01";
                }
                else if (litteralStrMass[i] == "E")
                {
                    litteralStrMass[i] = "02";
                }
                else if (litteralStrMass[i] == "I")
                {
                    litteralStrMass[i] = "03";
                }
                else if (litteralStrMass[i] == "N")
                {
                    litteralStrMass[i] = "04";
                }
                else if (litteralStrMass[i] == "O")
                {
                    litteralStrMass[i] = "05";
                }
                else if (litteralStrMass[i] == "T")
                {
                    litteralStrMass[i] = "06";
                }
                else if (litteralStrMass[i] == "B")
                {
                    litteralStrMass[i] = "70";
                }
                else if (litteralStrMass[i] == "C")
                {
                    litteralStrMass[i] = "71";
                }
                else if (litteralStrMass[i] == "D")
                {
                    litteralStrMass[i] = "72";
                }
                else if (litteralStrMass[i] == "F")
                {
                    litteralStrMass[i] = "73";
                }
                else if (litteralStrMass[i] == "G")
                {
                    litteralStrMass[i] = "74";
                }
                else if (litteralStrMass[i] == "H")
                {
                    litteralStrMass[i] = "75";
                }
                else if (litteralStrMass[i] == "J")
                {
                    litteralStrMass[i] = "76";
                }
                else if (litteralStrMass[i] == "K")
                {
                    litteralStrMass[i] = "77";
                }
                else if (litteralStrMass[i] == "L")
                {
                    litteralStrMass[i] = "78";
                }
                else if (litteralStrMass[i] == "M")
                {
                    litteralStrMass[i] = "79";
                }
                else if (litteralStrMass[i] == "P")
                {
                    litteralStrMass[i] = "80";
                }
                else if (litteralStrMass[i] == "Q") // Кто посмотрел - тот сдохнет!
                {
                    litteralStrMass[i] = "81";
                }
                else if (litteralStrMass[i] == "R")
                {
                    litteralStrMass[i] = "82";
                }
                else if (litteralStrMass[i] == "S")
                {
                    litteralStrMass[i] = "83";
                }
                else if (litteralStrMass[i] == "U")
                {
                    litteralStrMass[i] = "84";
                }
                else if (litteralStrMass[i] == "V")
                {
                    litteralStrMass[i] = "85";
                }
                else if (litteralStrMass[i] == "W")
                {
                    litteralStrMass[i] = "86";
                }
                else if (litteralStrMass[i] == "X")
                {
                    litteralStrMass[i] = "87";
                }
                else if (litteralStrMass[i] == "Y")
                {
                    litteralStrMass[i] = "88";
                }
                else if (litteralStrMass[i] == "Z")
                {
                    litteralStrMass[i] = "89";
                }
                else if (litteralStrMass[i] == " ")
                {
                    litteralStrMass[i] = "90";
                }
                else
                {
                    Console.WriteLine("* Error read litter!!!");
                }

                Console.Write("#");
            }

            Console.Write("]\n\n");
            string resultLitterToNum = string.Join(null, litteralStrMass);
            return resultLitterToNum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("        -------------------------------");
            Console.WriteLine("        | Welcome One-Time pad v.0.29A|");
            Console.WriteLine("        -------------------------------\n");

            Console.Write("* Enter menu litter, A - encryption, B - decryption: ");
            string menuLitter = Console.ReadLine().ToUpper();

            if (menuLitter == "A")
            {
                Encryption();
            }
            else if (menuLitter == "B")
            {
                // дешифрование
            }
            else
            {
                Console.WriteLine("* Wrong menu litter!!!");
            }

            Console.ReadLine();
        }
    }
}
