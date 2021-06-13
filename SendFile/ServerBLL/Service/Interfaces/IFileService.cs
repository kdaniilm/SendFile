using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Service.Interfaces
{
    public interface IFileService
    {
        byte[] SendFile(string log, string pass);

        void SaveFile(byte[] fileBytesArr, string name, int size);

        List<string> CreateLogPass();
    }
}
