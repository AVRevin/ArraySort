using System;
using System.Collections.Immutable;
using System.IO;
using System.Text;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // загрузка файла

            Console.WriteLine("Введите путь файла input.txt");
            Console.WriteLine("Например C:\\Massiv\\input.txt");
            string inputFileSource = Console.ReadLine();

            StreamReader reader = new StreamReader(inputFileSource);

            int inputArrayLenght = 0;
            string inputArrayString = null;
            int ouputMaxLenght = 0;
            string outputArray = null;

            for (int i = 0; i < 3; i++)
            {
                if (i == 0) { inputArrayLenght = Convert.ToInt32(reader.ReadLine()); }
                if (i == 1) { inputArrayString = reader.ReadLine(); }
                if (i == 2) { ouputMaxLenght = Convert.ToInt32(reader.ReadLine()); }
            }

            reader.Close();

            #endregion

            #region//основной код

            string[] stringarray = inputArrayString.Split(' ');
            int[] intputarray = new int[inputArrayLenght];

            for (int i = 0; i < inputArrayLenght; i++)
            {
                intputarray[i] = Convert.ToInt32(stringarray[i]);
            }

            Sorting.Sort(intputarray); // в сортировке используется Метод Шелла

            for (int i = intputarray.Length - 1; i >= intputarray.Length - ouputMaxLenght; i--)
            {
                outputArray += Convert.ToString(intputarray[i]) + " ";
            }

            #endregion

            #region  // сохранение файла

            string fileName = inputFileSource.Remove(inputFileSource.Length - 9, 9) + "output.txt";

            File.WriteAllText(fileName, outputArray);

            Console.WriteLine("Сохранение прошло успешно");

            # endregion 
        }
    }
}
