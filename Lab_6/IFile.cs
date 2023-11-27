using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public interface IFile
    {
        void Open();
        void Close();
        void Save();
    }
}
