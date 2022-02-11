using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace GeforyAPI
{
    public class content
    {
        public static void save(string Path, string[] contenttosave)
        {
            //Path.Replace(@"\", @"\\");
            System.IO.File.WriteAllLines(Path, contenttosave);
        }

        public static string[] load(string Path)
        {
            string[] lines = File.ReadAllLines(Path);
            return lines;
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }


      
    }
}
