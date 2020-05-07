using StorageLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageLibrary
{
    public class StorageFactory
    {

        public StorageFactory()
        {

        }

        public static IStorageMaster GetStorageMaster(StorageConfig storageconfig)
        {
            switch (storageconfig.GetType().ToString())
            {
                case "FileStorageConfig":
                    return new FileStorageMaster(storageconfig);
                case "AzureStorageConfig":
                    return new AzureStorageMaster(storageconfig);
            }
            throw new NotSupportedException("This type of storage option is not supported by this system.");
        }
    }
}
