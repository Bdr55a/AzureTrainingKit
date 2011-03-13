using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;

namespace GuestBook_Data
{
    public class GuestBookDataSource
    {
        private static CloudStorageAccount storageAccount;
        private GuestBookDataContext context;

        static GuestBookDataSource()
        {
            storageAccount = CloudStorageAccount.FromConfigurationSetting("DataConnectionString");
            CloudTableClient.CreateTablesFromModel(
                typeof(GuestBookDataContext), storageAccount.TableEndpoint.AbsoluteUri, storageAccount.Credentials);
        }
    }
}