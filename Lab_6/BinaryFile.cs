using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class BinaryFile : File
    {
        private int numberSystem;
        private string byteOrder; //порядок байтов
        private bool isHaveSymbols;

       
        public bool IsHaveSymbols { get => isHaveSymbols; set => isHaveSymbols = value; }
        public string ByteOrder { get => byteOrder; set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    byteOrder = value;
                }
                else
                {
                    throw new ArgumentException("ByteOrder name cannot be null or empty.");
                }
            }
        }
        public int NumberSystem { get => numberSystem; 
            set
            {
                if (value > 1 && value < 17)
                {
                    numberSystem = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public BinaryFile(string filename, string byteOrder, int numberSystem, bool isHaveSymbols) : base(filename)
        {
            ByteOrder = byteOrder;
            IsHaveSymbols = isHaveSymbols;
            NumberSystem= numberSystem;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Byte Order: {ByteOrder}, Number System: {NumberSystem}, Has Symbols: {IsHaveSymbols}";
        }
    }
}
