using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.StorageClient;

namespace GuestBook_Data
{
    public class GuestBookEntry : TableServiceEntity
    {
        public string GuestName { get; set; }
        public string Message { get; set; }
        public string PhotoUrl { get; set; }
        public string ThumbnailUrl { get; set; }

        public GuestBookEntry()
        {
            PartitionKey = DateTime.UtcNow.ToString("MMddyyyy");

            RowKey = string.Format("{0:10}_{1}", DateTime.MaxValue.Ticks - DateTime.Now.Ticks, Guid.NewGuid());
        }
    }
}
