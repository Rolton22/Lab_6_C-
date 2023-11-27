using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Files
    {
        private File[] files;
        public File[] File { get { return files; } }

        //конструктор по умолчанию
        //инициализирует объект пустым массивом
        public Files()
        {
            files = Array.Empty<File>();
        }

        //конструктор, принимающий переменное число объектов 
        public Files(params File[] file)
        {
            files = file;
        }

        //метод добавления нового файла
        public void AddFile(File file)
        {
            if (file != null) 
            {
                Array.Resize(ref files, files.Length + 1); // увеличение размера массива
                files[^1] = file; // добавление елемента в конец массива
            }else throw new ArgumentException("file is empty or null");

        }
        // метод удаления елемента по индексу
        public void RemoveFile(int index)
        {
            if (index >= 0 && index < files.Length) //проверка корректности индекса
            {
                for (int i = index; i < files.Length - 1; i++)
                {
                    files[i] = files[i + 1]; //сдвиг элементов для удаления
                }
                Array.Resize(ref files, files.Length - 1); //уменьшение размера массива
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }
        // метод реактирования елемента по индексу
        public void EditFile(int index, File newFile)
        {
            if (newFile != null) // проверка или newFile не null
            {
                if (index >= 0 && index < files.Length) //проверка коректности индекса
                {
                    files[index] = newFile; 
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
            else
            {
                throw new ArgumentException("New file is empty or null");
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(); 

            foreach (var file in files)
            {
                result.AppendLine(file.ToString());
            }н
            return result.ToString();
        }
    }
}
