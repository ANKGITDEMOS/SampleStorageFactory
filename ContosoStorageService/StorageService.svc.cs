using StorageLibrary;
using StorageLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ContosoStorageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IStorageService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        
        public object GetFile(string filename,string path, StorageConfig storageconfig)
        {
            return StorageFactory.GetStorageMaster(storageconfig).ReadFile(filename,path);
        }

        public object Read(string filename, string path, StorageConfig storageconfig)
        {
            throw new NotImplementedException();
        }

        public object WriteFile(string filename, string path, StorageConfig storageconfig)
        {
            throw new NotImplementedException();
        }
    }
}
