using StorageLibrary.Interfaces;

namespace StorageLibrary
{
    internal class AzureStorageMaster : IStorageMaster
    {
        private StorageConfig storageconfig;

        public AzureStorageMaster(StorageConfig storageconfig)
        {
            this.storageconfig = storageconfig;
        }

        public object ReadFile(string FileName, string Path)
        {
            throw new System.NotImplementedException();
        }
    }
}