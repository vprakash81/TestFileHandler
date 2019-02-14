using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    class VersionHandler : IFileHandler<string>
    {
        string _filePath = string.Empty;

        public VersionHandler(string FilePath)
        {
            _filePath = FilePath;
        }
        public Processors Get(string proces)
        {
            var regex = new System.Text.RegularExpressions.Regex("(v?|ver?)");
            return regex.IsMatch(proces) ? Processors.Version : Processors.NotFound;
                        
        }
        public string GetValue()
        {
            FileDetails fileDetails = new FileDetails();
            return fileDetails.Version(_filePath);

        }
    }

    
}
