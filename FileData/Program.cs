using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            if(!_validateArguments(args))
            {
                Environment.Exit(0);
            }

            List<IHandler> handlers = new List<IHandler> { new VersionHandler(args[1]), new SizeHandler(args[1]) };
            
            foreach (IHandler h in handlers)
            {
                switch(h.Get(args[0]))
                {
                    case Processors.Version:
                        Console.WriteLine(((VersionHandler)h).GetValue());
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case Processors.Size:
                        Console.WriteLine(((SizeHandler)h).GetValue());
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;                                        
                }                
            }
            
        }

        public static bool _validateArguments(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Help.\n\n -v for version \n\n -s for Size followed by file location ");
                return false;
            }
            var regex = new System.Text.RegularExpressions.Regex("(v?|version?|s?|size)");
            if(!regex.IsMatch(args[0]))
            {
                Console.WriteLine("Help.\n\n -v for version \n\n -s for Size followed by file location ");
            }
            return true;
            

        }
    }
}
