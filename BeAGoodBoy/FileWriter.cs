using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BeAGoodBoy
{
    class FileWriter
    {
        private FileStream fs1;
        private FileStream fs2;
        public FileWriter()
        {
            this.fs1 = new FileStream(@"题目.txt", FileMode.Create);
            this.fs2 = new FileStream(@"答案.txt", FileMode.Create);
        }

        public void WriteProblem(int i, string[] s)
        {
            byte[] bytes1;
            bytes1 = Encoding.UTF8.GetBytes("[" + (i + 1).ToString() + "]:  " + s[0] + "\r\n");
            fs1.Write(bytes1, 0, bytes1.Length);
            byte[] bytes2;
            bytes2 = Encoding.UTF8.GetBytes("[" + (i + 1).ToString() + "]:  " + s[1] + "\r\n");
            fs2.Write(bytes2, 0, bytes2.Length);
        }

        public void CloseFile()
        {
            fs1.Flush();
            fs2.Flush();
            fs1.Close();
            fs2.Close();
        }

    }
}
