namespace ConsoleApp2_c_
{
    internal class Program
    {//массивы и строки
        enum En { el1 = 1, el2 = 5 };
        static void Main(string[] args)
        {
            /*int[,] asd = new int[3, 2];//[]-конструктор / , добавление еще одного массива(двумерный и т.д.)
            int[,]asd1 = new int[3, 2] { { 1, 2 }, { 1, 2 }, { 1, 2 } };//инициализация двумерного массива

            int[][] asd2 = new int[3][];//зубчатый массив(массив с массивами)

            asd2[0] = new int[] { };
            asd2[1] = new int[] { };//инициализация зубчатого массива
            asd2[2] = new int[] { };

            int[] ss = new int[] { 1, 2, 3, 4, 5 };
            foreach(int i in ss)    //обычный цикл for
            {
                Console.WriteLine(i);
            }*/
            //Задача1. Четные нечетные, уникальные элементы массива
            /*   int[] arr = new int[] { 1, 2, 3123, 22, 56, 49, 53, 213, 444, 44444, 777, 999, 12, 234 };
               int chet =0, nechet =0, unique = 0;
               foreach(var item in arr)
               {
                   if (item % 2 == 0) chet++;
                   else nechet++;
                  for(int i =0; i< arr.Length; i++)
                   {
                       bool isUnique = true;
                       for(int j = 0; j<arr.Length; j++)
                       {
                           if (i != j && arr[i] == arr[j])
                           {
                               isUnique = false;
                               break;
                           }
                       }
                       if (isUnique) unique++;
                   }
                   Console.Write(chet);
                   Console.WriteLine(nechet);
                   Console.WriteLine(unique);
               }*/
            //Задача 2.
            /*  int[] arr2 = new int[] { 1, 2, 3123, 22, 56, 49, 53, 213, 444, 44444, 777, 999, 12, 234 };
              int num = Convert.ToInt32(Console.ReadLine()), count2 = 0;
              foreach (int item in arr2)
              {
                  if (item<num)
                  {
                      count2++;
                  }

              }*/
            //Задача 3. Минимум и максимум в двумерном массиве
            /*  int[,]  matrix1 = { { 1, 3, 5 },{ 2, 4, 6 },{ 10, 8, 9 } };
              //row = asd.GetLength(0);
              int rows = matrix1.GetLength(0);
              int cols = matrix1.GetLength(1);
              int min = matrix1[0,0],max = matrix1[0,0] ;
              for (int i = 0; i < rows ; i++) { 
                  for (int j = 0; j < cols ; j++)
                  {
                      if (matrix1[i, j] > max)
                      {
                          max= matrix1[i, j];
                      }
                      if (matrix1[i, j] < min)
                      {
                          min= matrix1[i, j];
                      }
                  }
              }
              Console.WriteLine(min.ToString());
              Console.WriteLine(max.ToString());
            */
            // string str = "asdasd";
            // char[] arr = str.ToCharArray();//перевод строки в символьный массив

            //  string str = Console.ReadLine();
            // string[] words = str.Split(" ");
            //Console.WriteLine(words.Length);

            //Задача 4. слова наоборот
            /* string str = Console.ReadLine();
             string [] words = str.Split(" ");
           foreach(var word in words)
             {
                 char[]charArray = word.ToCharArray();
                 Array.Reverse(charArray);
                 string reversedWords = new string (charArray);
                 Console.Write(reversedWords + " ");
             }

         }*/
            //форматирование строк
            //1. Интерполяция
            int num = 10;
            string str5 = $"цена:{num}";
            //2. Метод string.Format
            string str6 = String.Format("asdas{0},{1}", num, str5);
            //3. Метод Concat складывать строки
            string str7 = String.Concat("ASDAS", num);
            //4.сложение строк
            string str8 = str5 + str6;
            string str9 = "ASDAS" + str6;

        }
    }
}
