using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePhoto
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            Console.WriteLine("Loading photo");
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Saving photo");
        }
    }
}
