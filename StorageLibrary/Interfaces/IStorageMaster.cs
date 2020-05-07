using StorageLibrary.Interfaces;
using System;

namespace StorageLibrary
{
    public interface IStorageMaster
    {
        //public IStorageMaster GetStorageMaster(IStorageConfig storageconfig);

        object ReadFile(string FileName,string Path);

    }
}
