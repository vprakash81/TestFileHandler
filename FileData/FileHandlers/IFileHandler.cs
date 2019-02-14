using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FileData
{
   interface IHandler 
    {
        Processors Get(string parameter);
        
    }
    interface IFileHandler<TData>:IHandler
    {
        
    }
}
