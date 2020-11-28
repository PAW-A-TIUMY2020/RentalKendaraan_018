using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_018.Models.Upload
{
    public class FilesDetails
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class FilesViewModel
    {
        public List<FilesDetails> Files { get; set; }
            = new List<FilesDetails>();
    }
}
