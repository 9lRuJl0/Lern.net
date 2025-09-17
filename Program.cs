using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LernArray
{
    public class LernArray
    {
        static void Main(string[] args)
        {
            /* int[] array = { 1, 2, 3, 5, 6, 7, 8, 9, 10 };

             for (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine(array[i]);

             }


             int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

             for (int j = array2.Length - 1; j >= 0; j--)
             {
                 Console.WriteLine(array2[j]);
             }

             Console.ReadKey(); */


            /*пользователь вводит число N. тебе надо сформировать массив длинной N, заполненный числами от 1 до N, 
             * а затем вывести эти числа поочередно на консоль, начиная с конца массива.*/

            /* Console.Write("Введите количество элементов массива: ");

            int elementsArray = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsArray];

            for (int i = myArray.Length - 1; i >= 0; i--)
            {

                myArray[i] = i;
                Console.Write(myArray[i]);
            }

            Console.ReadKey(); */


            /* а теперь давай тут сделаем заполнение массива случайными числами от 0 до 100,
            * а на консоль надо вывести максимальный элемент массива (индекс и значение). 
            * заполнение массива и поиск давай разделим (не в одном цикле)*/

            /* var random = new Random();

             int[] myArray = new int[100]; // Выделяем память под массив
             int maxValue = 0; // Переменная максимального значения, изнаачльно равна 0
             int index = 0; // Переменная индекса

             for (int i = 0; i < myArray.Length; i++)
             {
                 myArray[i] = random.Next(100); // Заполняем массив рандомными числами

             }

             for (int i = 0; i < myArray.Length; i++)
             {
                 if (myArray[i] > maxValue) // Сравниваем значение в индексе с максимальным значением
                 {
                     maxValue = myArray[i]; // значение индекса
                     index = i; // порядковый номер индекса
                 }
             }
             Console.WriteLine($"Максимальное значение в массиве равно: {maxValue}"); // Выводим заксимальное значение
             Console.WriteLine($"Индекс максимального значения равен: {index}"); // Выводим номер индекса этого значения
             Console.ReadKey();
             } */


            /* давай теперь сумму четных элементов массива посчитаем. без рандома, элементы можешь захардкодить. */



            /* int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

             int sumValue = 1;


             for (int i = 0; i < myArray.Length; i++)
             {
                 if (myArray[i] % 2 == 0)
                 {
                     sumValue *= myArray[i];
                 }
             }
             Console.WriteLine(sumValue);
             Console.ReadKey(); */


            /* далее давай сделаем реверс массива:
            [1, 2, 3, 4] -> [4, 3, 2, 1]
            встроенную функцию реверса использовать нельзя.*/

            /* int[] myArray = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 101 };

            for (int i = 0; i < myArray.Length / 2; i++)
            {
                int valueIndex = myArray[i];

                myArray[i] = myArray[myArray.Length - 1 - i];

                myArray[myArray.Length - 1 - i] = valueIndex;

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadKey(); */


            // Не использовать переменную valueIndex

            /* int[] myArray = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 101 };

             for (int i = 0; i < myArray.Length / 2; i++)
             {

                 myArray[i] = myArray[i] + myArray[myArray.Length - 1 - i]; // сложение значений первого индекса и последнего
                                                                            // по мере прохождения по индексам складываем следующие значения индексов

                 myArray[myArray.Length - 1 - i] = myArray[i] - myArray[myArray.Length - 1 - i]; // записали в 1 индекс сумму 1 и последнего индекса,
                                                                                                 // далее делаем так же со вторым и так далее

                 myArray[i] = myArray[i] - myArray[myArray.Length - 1 - i]; // вычитаем новое значение индекса со значением начального индекса,
                                                                            // далее делаем также со вторым и так далее
             }

             for (int i = 0; i < myArray.Length; i++)
             {
                 Console.WriteLine(myArray[i]); // выводим значения индексов
             }

             Console.ReadKey();*/






            /* давай теперь задачу с поиском делать. 
             * пользователь вводит с клавиатуры число. если оно есть в массиве, 
             * надо вывести первую его позицию, иначе - вывести "-1".
 
            Console.WriteLine("Лотерея на угадывание числа находящегося в массиве! ");
            Console.Write("Введите число:\t");            
            int number = int.Parse(Console.ReadLine());
            
            int[] myArray = { 3, 4, 5};

            int valueIndex = -1;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (number == myArray[i])
                {
                    valueIndex = i;
                    Console.WriteLine($"Данное число {myArray[i]} присутствет в массиве, вы победили! ");
                    break;

                }
            } if (valueIndex > -1)
            Console.WriteLine("Вы не угадали, но могу вам показать -1 ");

            Console.ReadKey();*/








            /* найти в массиве номер последнего элемента который ввел пользователь*/

            /* int[] myArray = { 11, 11, 33, 33, 44, 55, 66, 77, 88, 99, 101, 111, 111 };

            int lastIndex = myArray[myArray.Length - 1];

            Console.WriteLine(lastIndex);

            Console.ReadKey(); */



            /* int[] myArray = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 101 };

            int lower = myArray.GetUpperBound(0); // используем сахар, методы GetUpperBound и GetLowerBound

            Console.WriteLine($"Последний номер элемента массива равен:\t{lower}");
            Console.ReadKey(); 

             /* Найти максимальное знаечение в массиве

            int[] myArray2 = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 101 };

            int maxValueIndex = myArray2.Max();

            for (int i = 0; i < myArray2.Length; i++)
            {
                if (myArray[i] == maxValueIndex)
                {
                    i = maxValueIndex;
                }

                Console.WriteLine($"Максимальный элемент массива равен:\t{maxValueIndex}");
                Console.ReadKey(); */




            /* Убрать дубликаты значений из массива*/

            /* int[] myArray = { 11, 11, 33, 33, 44, 55, 66, 77, 88, 99, 101, 111, 111 };

            var arrayNoRepetitions = myArray.Distinct();

            foreach (var s in arrayNoRepetitions)
               
            Console.WriteLine(s);

            Console.ReadKey(); */



            /*
            int[] myArray = { 11, 11, 33, 33, 44, 55, 66, 77, 88, 99, 101, 111, 111 };

            int[] myArray2 = new int[myArray.Length]; // новый массив куда запишем, числа без поворений

            int number = 0; // переменная уникальных чисел

            int duplicate; 

            for (int i = 0; i < myArray.Length; i++)
            {

                for (duplicate = 0; duplicate < number; duplicate++)
                {
                    if(myArray[i] == myArray2[duplicate]) // сравнение: текущий элемент первого массива с элементами второго массива
                    {
                        break;
                    }   
                }

                if (duplicate == number) // элемент не повторился
                {
                    myArray2[number] = myArray[i]; // записываем во второй массив

                    number++;
                }
            }
            
            for(int i = 0; i < number; i++) // бежим по второму массиву и выводим значения
            {
                Console.WriteLine(myArray2[i]);
            }

            Console.ReadKey(); */










            /* Найти все позиции элементов введеные пользователем, например юзер вводит 5 и необходимо найти все 5 по индексам, 
             * а если нет то выводить сообщение о том что нет данной цифры*/




            /*  Console.Write("Введите число элемента массива: ");

              var random = new Random();

              int elementsArray = int.Parse(Console.ReadLine());

              int[] myArray = new int[10];

              string work = " ";

              int valueIndex = -1;

              int i;

              for (i = 0; i < myArray.Length; i++)

              {
                  myArray[i] = random.Next(10);


                  if (myArray[i] == elementsArray)
                  {
                      valueIndex = i;

                      Console.WriteLine($"Введенное вами число присутствет в массие под индексом: {i}");

                  }
              }

              if (valueIndex <= -1)
              {
                  Console.WriteLine("Введенное вами число отсутствует в массиве. ");

              }
              Console.WriteLine($"Наш массив состоит из {myArray.Length} элементов. Их значения:");

              for (int j = 0; j < myArray.Length; j++)
              {
                  Console.Write(myArray[j] + " ");
              }
              Console.WriteLine();


              while (work != "Y")
              {
                  Console.Write("Попробуете еще раз? Чтобы продолжить нажмите Y, закончить нажмите Q - ");
                  work = Convert.ToString(Console.ReadLine());
                  switch (work)
                  {
                      case "Y":
                          Console.WriteLine("Продолжаем испытывать удачу");
                          break;

                      case "Q":
                          Console.WriteLine("Вы выбрали завершение программы");
                          Environment.Exit(0);
                          break;

                      default:
                          Console.WriteLine("Вы ввели некорректные данные, пожалуйста повторите ввод");
                          break;
                  }

                  Console.ReadKey(); */



            /* давай тогда сортировку сделаем для закрепления. и потом упростим твое решение с дедупликацией уже по отсортированному массиву.

            надо написать сортировку по возрастанию методом пузырька.
            [5, 3, 8, 1, 3]-> [1, 3, 3, 5, 8] */




            /* int[] myArray = { 111, 111, 77, 33, 44, 55, 57, 66, 33, 88, 99, 101, 11, -11 };

             Console.Write("Start :");

             for (int i = 0; i < myArray.Length; i++)
             {

                 Console.Write(" {0}", myArray[i]);
             }


             for (int i = 0; i < myArray.Length; i++)
             {
                 for (int j = 0; j < myArray.Length - 1; j++)
                 {
                     if (myArray[j + 1] < myArray[j])
                     {
                         int value = myArray[j];

                         myArray[j] = myArray[j + 1];

                         myArray[j + 1] = value;

                     }

                 }
             }
             Console.WriteLine("\nОтсортированный массив: ");

             for (int k = 0; k < myArray.Length; k++)
             {
                 Console.Write(" {0}", myArray[k]);
             }
             Console.ReadKey(); */



            ////////////////////////////////////////////////////////////////////////////////////////

            /* давай сортировку вставками сделаем */

            /* int[] myArray = { 111, 111, 77, 33, 44, 55, 57, 66, 33, 88, 99, 101, 11, -11 };

             int i, j, k;

             Console.Write("Start  :");

             for (i = 0; i < myArray.Length; i++)
             {

                 Console.Write(" {0}", myArray[i]);

             }

             for (j = 0; j < myArray.Length; j++)
             {
                 int valueIndex = myArray[j];

                 i = j - 1;

                 while(i >= 0 && myArray[i] > valueIndex)
                 {              
                     myArray[i + 1] = myArray[i];

                     i = i - 1;              
                 }

                 myArray[i + 1] = valueIndex;
             }    
             Console.WriteLine("\nОтсортированный массив алгоритмом вставок: ");

             for (k = 0; k < myArray.Length; k++)
             {
                 Console.Write(" {0}", myArray[k]);
             }
             Console.ReadKey(); */



            /*
            Console.Write("Введите число размерности массива от 5 до 20: ");

            var random = new Random();

            int elementsArray = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsArray];

            Console.Write("Поглядите на ваш массив наглядно: ");

            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(elementsArray);

                Console.Write(" {0}", myArray[i]);
            }

            
            int j = 1;

            while (j < myArray.Length)
            {
                if (j == 0 || myArray[j - 1] <= myArray[j])
                {
                    j++; 
                }
                else
                {
                    
                    int temp = myArray[j];

                    myArray[j] = myArray[j - 1];

                    myArray[j - 1] = temp;

                    j--; 
                }
            }

            Console.Write("\nОтсортированный массив алгоритмом Gnome Sort: ");

            for (int k = 0; k < myArray.Length; k++)
            {
                Console.Write(" {0}", myArray[k]);
            }

            Console.ReadKey();  */


            /////////////////////////////////////////////////////////////////////////////////

            /* Задача Сергея 
             * Написать программу, которая определяет, будет ли положительное целое число степеью 4 
            
            
            Console.Write("Введите число размерности массива от 1 до 1000: ");

            int number = int.Parse(Console.ReadLine());
            string work = "";


            if (number <= 0)
            {
                Console.WriteLine("Введено число ноль либо отрицательно число, так не годится! ");
            }

            else
            {
                while (number % 4 == 0)
                {
                    number /= 4;
                }

                if (number == 1)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
                
            }
            Console.ReadKey(); */


            /////////////////////////////////////////////////////////////////////////////////////////////



            /* Есть 2 строки S и T, состоящие только из строчных букв. Строка T получена перемешиванием букв строки S и добавление 1 буквы в случайную позицию
             * Нужно найти добавленую букву */

            /* string[] arrS = { "a", "b", "c", "d" };

             string[] arrT = { "a", "b", "c", "d", "e" };

             int i, j, k;

             for (i = 0; i < arrS.Length; i++)
             {
                 for (j = 0; j < arrT.Length - 1; j++)
                 {
                     if (arrT[j + 1] < arrT[j])
                     {
                         string value = arrT[j];

                         arrT[j] = arrT[j + 1];

                         arrT[j + 1] = value;

                     }

                 }
             }
             Console.WriteLine("\nОтсортированный массив: ");

             for (k = 0; k < arrT.Length; k++)
             {
                 Console.Write(" {0}", arrT[k]);
             }
             Console.ReadKey(); */

            /*
            string[] arrS = { "a", "b", "c", "d" };
            string[] arrT = { "b", "a", "c", "d", "e" };

            int i, j, k;

            for (i = 0; i < arrS.Length; i++)
            {
                for (j = 0; j < arrT.Length - 1; j++)
                {
                    if (arrT[j + 1] == (arrT[j]))
                    {
                        string value = arrT[j];
                        arrT[j] = arrT[j + 1];
                        arrT[j + 1] = value;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив:");
            for (k = 0; k < arrT.Length; k++)
            {
                Console.Write(" {0}", arrT[k]);
            }
            Console.ReadKey(); */

            /* найти сначало большой массим и потом сравнить с маленьким массивом */



            /* string[] arrS = { "a", "b", "c", "d" };
             string[] arrT = { "b", "a", "l", "c", "d" };

             string[] masB = null;
             string[] masS = null;

             if (arrS.Length > arrT.Length)
             {
                 masB = arrS;
                 masS = arrT;
             }
             else
             {
                 masB = arrT;
                 masS = arrS;
             }

             string symbol = null;
             for (int i = 0; i < masB.Length; i++)
             {
                 for (int j = 0; j < masS.Length; j++)
                 {
                     if (masB[i] == masS[j])
                     {
                         symbol = masB[i];
                         continue;
                     }

                 }
                 Console.Write(masB[i]);
             }

             Console.ReadKey(); */

            /* Есть 2 строки S и T, состоящие только из строчных букв. Строка T получена перемешиванием букв строки S и добавление 1 буквы в случайную позицию
            * Нужно найти добавленую букву */

            /* string s = "abcd";
            string t = "bacdl"; 

            char result = '\0'; 

            foreach (char c in s)
            {
                result ^= c;
            }

            foreach (char c in t)
            {
                result ^= c;
            }

            Console.WriteLine("Добавленная буква: " + result); */



            ////////////////////////////////////////////////////////////////////////////////////

            /* Задача Кирилла
             * Есть длинный одномерный массив, например на 20 целочисленных элементов, каждый элемент массива - цифра. 
             * Заполнить случайно. Нужно подсчитать количество всех одинаковых цифр в нем, сколько ноликов, сколько единиц и тд */




            /* Random random = new Random();

             int[] myArray = new int[20];

             int i, j, k, r;

             for (i = 0; i < myArray.Length; i++)
             {
                 myArray[i] = random.Next(0, 19);

                 Console.Write(" {0}", myArray[i]);

             }

             for (i = 0; i < myArray.Length; i++)
             {

                 Console.Write(" {0}", myArray[i]);

             }

             for (j = 0; j < myArray.Length; j++)
             {
                 int valueIndex = myArray[j];

                 i = j - 1;

                 while (i >= 0 && myArray[i] > valueIndex)
                 {
                     myArray[i + 1] = myArray[i];

                     i = i - 1;
                 }

                 myArray[i + 1] = valueIndex;
             }
             Console.WriteLine("\nОтсортированный массив алгоритмом вставок: ");

             for (k = 0; k < myArray.Length; k++)
             {
                 Console.Write(" {0}", myArray[k]);
             }

             int[] myArray2 = new int[myArray.Length];

             int number = 0;

             int duplicate;

             for (r = 0; r < myArray.Length; i++)
             {

                 for (duplicate = 0; duplicate < number; duplicate++)
                 {
                     if (myArray[i] == myArray2[duplicate])
                     {
                         break;
                     }
                 }
                 Console.WriteLine(myArray2[duplicate]);


                 if (duplicate == number)
                     myArray2[number] = myArray[i];

                 number++;
             }
             Console.ReadKey(); */

             Random random = new Random();

             int[] myArray = new int[20];

             int[] myArray2 = new int[10]; 

             Console.WriteLine("Случайный массив из 20 цифр: ");

             for (int i = 0; i < myArray.Length; i++)
             {
                 myArray[i] = random.Next(0, 10); 

                 Console.Write(myArray[i] + " ");

                 int number = myArray[i];

                 myArray2[number]++; 
             }

             Console.WriteLine("\n\nПодсчёт количества каждой цифры:");

             for (int i = 0; i < myArray2.Length; i++)
             {
                 Console.WriteLine($"Цифра {i} встречается {myArray2[i]} раз(а)");
             }

             Console.ReadKey();


         }

     } 

} 








