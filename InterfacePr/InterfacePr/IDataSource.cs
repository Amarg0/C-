using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePr
{
    interface IDataSource
    {
        void Open();
        void Load();
        void Parse();
        void GetData();
        void Close(string answer);

    }
}
