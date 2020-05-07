using StorageLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageLibrary
{
    public class AzureStorageConfig : StorageConfig
    {
        public string StorageAccountName { get; set; }
        public string StorageAccountKey { get; set; }
        public string containername { get; set; }
    }
}
