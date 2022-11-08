using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Valid_Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,,] array = new int[9, 3, 3];
            Random rnd = new Random();
            int randomNumber=0;
            int setNumberCount = 0;
            int index;
           // array1[0,2]=1;


            // create sudoku board
            for(int a = 0; a < 9; a++)
            {
               // array = new int[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        array[a, i, j] = 0;
                    }
                }
                //list.Add(array);
            }

            int rest;
            bool occupied = false;
            int ra; // random array
            int rx; // random x
            int ry; // random y
            // setting numbers
             while (setNumberCount < 27)
             {
                while (true)
                {

                    occupied = false;
                    ra = rnd.Next(0, 9);
                    rx = rnd.Next(0, 3);
                    ry = rnd.Next(0, 3);
                    randomNumber = rnd.Next(1, 10);
                    rest = ra % 3;


                    //check square
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (array[ra, i, j] == randomNumber)
                            {
                                occupied = true; 
                                break;
                            }
                        }
                    }


                    // if random array with random index is empty
                    if (occupied==false && array[ra,rx,ry] == 0)
                    {

                        for (int i = 0; i < 9; i++)
                        {
                            //occupied = false;

                            //check vertical
                            if (i % 3 == rest)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    if (array[i, rx, j] == randomNumber)
                                    {
                                        occupied = true; 
                                        break;
                                    }
                                }
                            }

                                //check horizontal
                                //i nr listy
                            if (occupied == false)
                            {
                                if (i >= 0 && i <= 2)
                                {
                                    for (int k = 0; k <= 2; k++) //nr kratki
                                    {
                                        for (int l = 0; l <= 2; l++) //nr x
                                        {
                                            if (array[k, l, ry] == randomNumber)
                                            {
                                                occupied = true;
                                                break;
                                            }
                                        }

                                    }
                                }
                                else if (i >= 3 && i <= 5)
                                {
                                    for (int k = 3; k <= 5; k++)
                                    {
                                        for (int l = 0; l <= 2; l++)
                                        {
                                            if (array[k, l, ry] == randomNumber)
                                            {
                                                occupied = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                                else if (i >= 6 && i <= 8)
                                {
                                    for (int k = 6; k <= 8; k++)
                                    {
                                        for (int l = 0; l <= 2; l++)
                                        {
                                            if (array[k, l, ry] == randomNumber)
                                            {
                                                occupied = true;
                                                break;
                                            }
                                        }
                                    }
                                 }

                            }
                            if (occupied == true)
                            {
                                break;
                            }
                        }
                        if (occupied == false)
                        {
                            array[ra, rx, ry] = randomNumber; 
                            setNumberCount+=1; 
                            break;
                        }

                    }

                }
             }

            // show sudoku board
            index = 0;
            for (int a=0;a<9;a++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(array[a, i, j] + " ");
                    }
                    if (i == 2)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                if (index % 3 == 2) Console.WriteLine();
                index++;
            }
            Console.ReadLine();
        }
    }
}
