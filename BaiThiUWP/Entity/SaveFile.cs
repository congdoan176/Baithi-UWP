using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiUWP.Entity
{
    class SaveFile
    {
        private String _fileName;
        private String _content;

        public string fileName { get => _fileName; set => _fileName = value; }
        public string content { get => _content; set => _content = value; }
    }
}
