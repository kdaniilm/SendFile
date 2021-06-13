using ServerBLL.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Service
{
    public class FileService : IFileService
    {
        public List<string> CreateLogPass()
        {
            throw new NotImplementedException();
        }

        public void SaveFile(byte[] fileBytesArr, string name, int size)
        {
            throw new NotImplementedException();
        }

        public byte[] SendFile(string name, int size)
        {
            throw new NotImplementedException();
        }

        public byte[] SendFile(string log, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
