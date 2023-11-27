using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class TextFile : File
    {
        private string coding;
        private string fileExtension;
        private bool isFormattedText;

       

        public bool IsFormattedText { get => isFormattedText; set => isFormattedText = value; }
        public string FileExtension { get => fileExtension; 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    fileExtension = value;
                }
                else
                {
                    throw new ArgumentException("File name cannot be null or empty.");
                }
            }
        }
        public string Coding { get => coding; set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    coding = value;
                }
                else
                {
                    throw new ArgumentException("File name cannot be null or empty.");
                }
            }
        }
        public TextFile(string filename, string fileExtension, string coding, bool isFormattedText) : base(filename)
        {
            FileExtension = fileExtension;
            Coding = coding;
            IsFormattedText=isFormattedText;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, File Extension: {FileExtension}, Coding: {Coding}, Has FormattedText: {IsFormattedText}";
        }
    }
}
