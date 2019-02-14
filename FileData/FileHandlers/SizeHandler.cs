using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;
namespace FileData
{
    class SizeHandler : IFileHandler<int>
    {
        string _filePath = string.Empty;

        public SizeHandler(string FilePath)
        {
            _filePath = FilePath;
        }
        public Processors Get(string proces)
        {
            var regex = new System.Text.RegularExpressions.Regex("(s?|size?)");
            return regex.IsMatch(proces) ? Processors.Size : Processors.NotFound;
        }
        public int GetValue()
        {
            FileDetails fileDetails = new FileDetails();
            return fileDetails.Size(_filePath);
            
        }
    }
}
