using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drive_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] myDrives =DriveInfo.GetDrives();
        }
    }
}
