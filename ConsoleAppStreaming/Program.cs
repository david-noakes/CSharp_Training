using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStreaming
{
    class Program
    {
        static String resourcePath = "C:/Data/Source/Repos/CSharp_Training/ConsoleAppStreaming/Resources";
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String sRead = resourcePath + "/quote.txt";
            String sWrite = resourcePath + "/quote.tmp";
            Program p = new Program();
            byte[] zb = p.StreamIn(sRead);
            p.StreamOut(sWrite, zb);
        }
         private byte[] StreamIn(String sReadIt)
        {
            // reading data from a filestream
            using (FileStream fs = new FileStream(sReadIt, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                int bytesToRead = (int)fs.Length;
                int bytesRead = 0;
                while (bytesToRead > 0)
                {
                    int n = fs.Read(bytes, bytesRead, bytesToRead);
                    if (n == 0) break;
                    bytesRead += n;
                    bytesToRead -= n;
                }
                bytesToRead = bytes.Length;
                Console.WriteLine("Read {0} bytes from original file...", bytesRead);
                return bytes;
            }
    
        }
        private void StreamOut(String sWriteIt, byte[] bWriteThis)
        {
            using (FileStream fsWrite = new FileStream(sWriteIt, FileMode.Create, FileAccess.Write))
            {
                fsWrite.Write(bWriteThis, 0, bWriteThis.Length);
                Console.WriteLine("Wrote new file successfully...");
            }
        }
    }
}
