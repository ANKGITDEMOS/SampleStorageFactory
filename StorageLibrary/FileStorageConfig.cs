using StorageLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageLibrary
{
    public class FileStorageConfig : StorageConfig
    {
        public string OnPremServerAddress { get; set; }
        public string OtherDetails { get; set; }

        //public string GetCacheValue(string key)
        //{
        //    try
        //    {
        //        string val = string.Empty;
        //        lock (new object())
        //        {
        //            //Read from Cache
        //            string val = readfromcache();
        //            //Not Found
        //            val = ReadFromDB();

        //            //Writing to Cache

        //            //Write to Cache
        //            WriteToCache(key, val);
        //        }
        //        return value;
        //    }catch(Exception ex)
        //    {
        //        throw ex;//NONO
        //        //Right if used in DAL, API Layer
        //        throw new Exception("Cache Value Exception occurred",ex);
        //        //For Web Layer
        //        //NOT TO DO DB SAVE FROM NOW ONWARDS
        //        string trackingid = logger.log(ex); //On Azure Tables
        //        throw new Exception("Some error occurred please connect with your administration - tracking id :" +  trackingid);
        //        {//ReadException

        //            //Read Exception + Read StackTrace
        //            // While innerexception != null
        //            //ReadException(Inner Exception);
        //        }
        //    }

        //}

    }
}
