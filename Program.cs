using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0;i<100;i++)
            {
                Console.WriteLine(File.GetLastWriteTime(@"\\fs\DbBackUps\AutoTestStorage\Acumatica\5.00.2515\lin-mysql\api.tar").ToString());
            }

            Console.ReadLine();
        }
    }
}
