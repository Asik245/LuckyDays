using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDays
{
   

    
        internal class Program
        {
            // стартоввый каптиал
            const int StartingCoins = 100;

            // это награды за совпадения символов
            const int ThreeMatchReward = 50;
            const int TwoMatchReward = 10;

            static void Main(string[] args)
            {
                int coins = StartingCoins;
                bool gameRunning = true;
                Random random = new Random();

                Console.WriteLine("========================");
                Console.WriteLine(" LUCKY DAYS");
                Console.WriteLine("========================");

                while (gameRunning)
                {
                    Console.WriteLine();
                    Console.WriteLine("Виртуальные монеты: " + coins);
                    Console.WriteLine("1 - Играть");
                    Console.WriteLine("2 - Выйти");
                    Console.Write("Выбери команду: ");

                    string command = Console.ReadLine();

                    if (command == "1")
                    {
                        // тут короче три случайных символа от 1 до 7
                        int firstNumber = random.Next(1, 8);
                        int secondNumber = random.Next(1, 8);
                        int thirdNumber = random.Next(1, 8);

                        Console.WriteLine();
                        Console.WriteLine("Результат: "
                        + firstNumber + " | "
                        + secondNumber + " | "
                        + thirdNumber);

                        if (firstNumber == secondNumber &&
                        secondNumber == thirdNumber)
                        {
                            coins = coins + ThreeMatchReward;
                            Console.WriteLine("HERE'S COME THE MONEY! +50 монет");
                        }
                        else if (firstNumber == secondNumber ||
                        firstNumber == thirdNumber ||
                        secondNumber == thirdNumber)
                        {
                            coins = coins + TwoMatchReward;
                            Console.WriteLine("Два совпадения! +10 монет");
                        }
                        else
                        {
                            Console.WriteLine("Совпадений нет.");
                        }
                    }
                    else if (command == "2")
                    {
                        gameRunning = false;
                        Console.WriteLine("Спасибо за игру!");
                    }
                    else
                    {
                        Console.WriteLine(
                        "Неизвестная команда. Введи 1 или 2.");
                    }
                }
            }
        }
    }

