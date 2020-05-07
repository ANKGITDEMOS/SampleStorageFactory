using StorageLibrary.Interfaces;

namespace StorageLibrary
{
    internal class FileStorageMaster : IStorageMaster
    {
        private StorageConfig storageconfig;

        public FileStorageMaster(StorageConfig storageconfig)
        {
            this.storageconfig = storageconfig;
        }

        public object ReadFile(string FileName, string Path)
        {
            throw new System.NotImplementedException();
        }
    }
}