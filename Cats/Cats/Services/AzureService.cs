using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Cats.Services
{
    public class AzureService<T>
    {
        private IMobileServiceClient Client;
        private IMobileServiceTable<T> Table;

        public AzureService()
        {
            string MyAppServiceURL = "http://catsazure.azurewebsites.net";
            Client = new MobileServiceClient(MyAppServiceURL);
            Table = Client.GetTable<T>();
        }

        public Task<IEnumerable<T>> GetTable()
        {
            return Table.ToEnumerableAsync();
        }
    }
}
