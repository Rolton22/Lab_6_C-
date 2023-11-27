using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public abstract class File : IFile
    {
        private readonly string fileName;
        private readonly string open = "opening";
        private readonly string save = "saving";
        private readonly string close = "closing";
        private string currentFunc;
        public string CurrentFunc
        {
            get => currentFunc;
            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    currentFunc = value;
                }
                else
                {
                    throw new ArgumentException("Funtion name cannot be null or empty.");
                }
            }
        }
        public string FileName
        {
            get => fileName;
            init
            {
                if (!string.IsNullOrEmpty(value)) 
                {
                    fileName = value;
                }
                else
                {
                    throw new ArgumentException("Filename name cannot be null or empty.");
                }
            }
        }
        public File(string filename)
        {
            FileName = filename;
            currentFunc = close;
        }
        public void Close()
        {
            if(currentFunc!=close)
                currentFunc = close;
        }

        public void Open()
        {
            if (currentFunc != open)
                currentFunc = open;
        }

        public void Save()
        {
            if (currentFunc != save)
                currentFunc = save;

        }
        public override string ToString()
        {
            return $"Filename: {FileName}, Current Function: {CurrentFunc}";
        }
    }
}
