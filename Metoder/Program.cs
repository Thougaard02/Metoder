using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opg 1
            //Console.WriteLine("Indsæt heltal (A)");
            //int userInputA = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Indsæt heltal (B)");
            //int userInputB = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Addition = {Addition(userInputA, userInputB)}");
            //Console.WriteLine($"Division = {Division(userInputA, userInputB)}");
            //Console.WriteLine($"Modulus = {Modulus(userInputA, userInputB)}");
            //Console.WriteLine($"Potency = {Potency(userInputA, userInputB)}");
            #endregion
            #region Opg2
            //Console.WriteLine("Indtast 1 heltal (1)");
            //int userinputA = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Indtast 1 heltal (2)");
            //int userinputB = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(FindC(userinputA, userinputB));
            #endregion
            #region Opg 3
            //Console.WriteLine("Insert name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Insert age");
            //byte age = Convert.ToByte(Console.ReadLine());

            //Console.WriteLine(checkAge(name, age));
            #endregion
            #region Opg 4
            //Console.WriteLine(OneToTeen());
            #endregion
            #region Opg 5
            //Console.WriteLine(TeenToOne());
            #endregion
            #region Opg 6
            //Console.WriteLine("Indtast et heltal!");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Counter(userInput));
            #endregion
            #region Opg 7
            //Array();
            #endregion
            #region Opg 8
            //RemoveNumbers();
            #endregion
            #region Opg 9
            //Console.WriteLine("Winning lotto Coupon");
            //randomTicketGen();
            //checkWin(macthingNumbers);
            #endregion
            #region Opg 10
            //CheckGuess();
            #endregion
            #region Opg 11
            ///////////////////////////////////////////////////////////////////////
            //I have used the same list 3 times! Remeber to comment out the list!//
            ///////////////////////////////////////////////////////////////////////

            //Console.WriteLine("Indtast 1 heltal (A)");
            //int userInuputA = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Indtast 1 heltal (B)");
            //int userInuputB = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(SumOfUserinput(userInuputA, userInuputB));

            //Console.WriteLine(SumOfParameter(2, 2));

            //Console.WriteLine(SumOfMultiply(2, 3));

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //Console.WriteLine(SumOfList(numbers));

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //Console.WriteLine(CheckElementes(numbers));

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //Console.WriteLine(ListsAvg(numbers));
            #endregion
            Console.ReadKey();
        }
        #region Opg 1
        static int Addition(int userInputA, int userInputB)
        {
            return userInputA + userInputA;
        }
        static int Division(int userInputA, int userInputB)
        {
            return userInputA / userInputA;
        }
        static int Modulus(int userInputA, int userInputB)
        {
            return userInputA % userInputA;
        }
        static double Potency(int userInputA, int userInputB)
        {
            //Can't Convert 2^3!
            return (int)Math.Pow(userInputB, userInputB);
        }
        #endregion
        #region Opg 2
        static double FindC(int userinputA, int userinputB)
        {
            int c2 = (userinputA * userinputA) + (userinputB * userinputB);

            double c = Math.Sqrt(c2);

            return c;
        }
        #endregion
        #region Opg 3
        static string checkAge(string name, byte age)
        {
            if (age < 3)
            {
                return $"{name}, du må gå med ble";
            }
            else if (age >= 3 && age <= 15)
            {
                return $"{name}, du må ingenting";
            }
            else if (age > 15 && age < 18)
            {
                return $"{name}, du må drikke";
            }
            else if (age >= 18)
            {
                return $"{name}, du må stemme og køre bil";
            }
            return "";
        }
        #endregion
        #region Opg 4
        static string OneToTeen()
        {
            string count = "";
            for (int i = 1; i <= 10; i++)
            {
                count += $"{i}\n";
            }
            return count;
        }
        #endregion
        #region Opg 5
        static string TeenToOne()
        {
            string count = "";
            for (int i = 10; i >= 1; i--)
            {
                count += $"{i}\n";
            }
            return count;
        }
        #endregion
        #region Opg 6

        static int Counter(int userInput)
        {
            for (int i = 0; i < 32; i++)
            {
                userInput += 1;
            }
            for (int i = 0; i < 16; i++)
            {
                userInput -= 1;
            }
            return userInput;
        }
        #endregion
        #region Opg 7
        static void Array()
        {
            int[] arr = new int[10];

            for (int i = 1; i < 10; i++)
            {
                arr[i] = i;
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine($"Finder tallet på plads {arr[5]}");
            arr[5] = 10;
            Console.WriteLine($"Ændret værdien på plads fem {arr[5]}");
        }
        #endregion
        #region Opg 8
        static void RemoveNumbers()
        {
            //2,4,5,8,10,11,14,16,17,19,20
            List<int> listeB = new List<int>();
            List<int> listeC = new List<int>();
            for (int i = 1; i < 21; i++)
            {
                listeB.Add(i);
            }
            listeB[3] = 17;
            for (int i = 1; i < listeB.Count; i++)
            {
                if (listeB[i] % 3 == 0)
                {
                    listeB.RemoveAt(i);
                }
                Console.WriteLine(listeB[i]);
            }
            Console.WriteLine();
            listeB.Reverse();
            listeC = listeB;
            for (int i = 1; i < listeC.Count; i++)
            {
                Console.WriteLine(listeC[i]);
            }
        }
        #endregion
        #region Opg 9
        static int[] winnerTicket = new int[6];
        static int[] userCoupon = new int[7] { 1, 2, 3, 4, 5, 8, 12 };
        static int macthingNumbers = 0;
        static Random r = new Random(Guid.NewGuid().GetHashCode());
        static void randomTicketGen()
        {
            for (int i = 0; i < winnerTicket.Length; i++)
            {
                winnerTicket[i] = r.Next(1, 20);
                Console.WriteLine(i + 1 + " " + winnerTicket[i]);
            }

            for (int i = 0; i < winnerTicket.Length; i++)
            {
                foreach (int num in userCoupon)
                {
                    if (winnerTicket[i] == num)
                    {
                        macthingNumbers++;
                        break;
                    }
                }
            }
        }
        static void CheckWin(int macthingNumbers)
        {
            switch (macthingNumbers)
            {
                case 0:
                    Console.WriteLine("Not today you won 0 kr");
                    break;
                case 1:
                    Console.WriteLine("You won 10 kr!");
                    break;
                case 2:
                    Console.WriteLine("You won 20 kr!");
                    break;
                case 3:
                    Console.WriteLine("You won 40kr!");
                    break;
                case 4:
                    Console.WriteLine("You won 80 kr!");
                    break;
                case 5:
                    Console.WriteLine("You won 160 kr!");
                    break;
                case 6:
                    Console.WriteLine("You won 320 kr!");
                    break;
            }
        }
        #endregion
        #region Opg 10

        static void CheckGuess()
        {
            Random ran = new Random();
            int securedNumber = ran.Next(1, 11);
            int guessNumber = 0;
            while (true)
            {
                Console.WriteLine("Gæt et tal mellem 1-10");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < securedNumber)
                {
                    Console.WriteLine("Højere");
                    guessNumber++;
                    Console.WriteLine($"Du har brugt {guessNumber} forsøg");
                }
                else if (guess > securedNumber)
                {
                    Console.WriteLine("Lavere");
                    guessNumber++;
                    Console.WriteLine($"Du har brugt {guessNumber} forsøg");

                }
                else if (guess == securedNumber)
                {
                    Console.WriteLine("Godt gættet!");
                    guessNumber++;
                    Console.WriteLine($"Du gættet tallet på {guessNumber} forsøg");
                    break;
                }
            }

        }
        #endregion
        #region Opg 11
        static string SumOfUserinput(int userInputA, int userInputB)
        {
            int sum = userInputA + userInputB;
            return $"Sum = {sum}";
        }
        static string SumOfParameter(int a, int b)
        {
            int sum = a / b;
            return $"Division sum = {sum}";
        }
        static string SumOfMultiply(int a, int b)
        {
            int sum = b * a;
            return $"Multiply sum = {sum}";
        }
        static string SumOfList(List<int> list)
        {
            int higestNum = list.Max();
            return $"Higest number in list = {higestNum}";
        }
        static bool CheckElementes(List<int> list)
        {
            if (list == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static string ListsAvg(List<int> list)
        {
            int sum = list.Sum();
            double avg = sum / list.Count;
            return $"{avg}";
        }

        #endregion
    }
}

