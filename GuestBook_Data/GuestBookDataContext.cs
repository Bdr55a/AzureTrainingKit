using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.StorageClient;
using Microsoft.WindowsAzure;

namespace GuestBook_Data
{
    public class GuestBookDataContext : TableServiceContext
    {
        public IQueryable<GuestBookEntry> GuestBookEntry
        {
            get
            {
                return this.CreateQuery<GuestBookEntry>("GuestBookEntry");
            }
        }

        public GuestBookDataContext(string baseAddress, StorageCredentials credentials) : base(baseAddress, credentials)
        {}
    }
}
