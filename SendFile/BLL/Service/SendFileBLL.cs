using BLL.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class SendFileBLL : ISendFile
    {
        public byte[] GetFile(string path)
        {
            var fileArr = new byte[0];

            return fileArr;
        }

        public bool SendFileToServer()
        {
            throw new NotImplementedException();
        }
    }
}
