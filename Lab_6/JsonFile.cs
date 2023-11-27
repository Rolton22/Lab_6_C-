using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class JsonFile : File
    {
        private string fileStructure; 
        private string fileExtension;
        private bool isHaveReferences;
        public bool IsHaveReferences { get => isHaveReferences; set => isHaveReferences = value; }
        public string FileExtension { get => fileExtension; 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    fileExtension = value;
                }
                else
                {
                    throw new ArgumentException("FileExtension name cannot be null or empty.");
                }
            }
        }
        public string FileStructure { get => fileStructure; 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    fileStructure = value;
                }
                else
                {
                    throw new ArgumentException("FileStructure name cannot be null or empty.");
                }
            }
        }
        public JsonFile(string filename, string fileStructure, string fileExtension, bool isHaveReferences) : base(filename)
        {
            FileExtension = fileExtension;
            FileStructure= fileStructure;
            IsHaveReferences = isHaveReferences;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, File Structure: {FileStructure}, File Extension: {FileExtension}, Has References: {IsHaveReferences}";
        }
    }
}
