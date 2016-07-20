using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Common;
using DataLayer.DataAccess;

namespace DataLayer.Validation
{
    public class ClientValidation
    {
        public static int AddClient(Client client)
        {
            if (validate(client))
            {
                return ClientRepository.AddClient(client);
            }
            else
            {
                return 0;
            }
        }

        public static int UpdateClient(Client client)
        {
            if (validate(client))
            {
                return ClientRepository.UpdateClient(client);
            }
            else
            {
                return 0;
            }
        }

        private static bool validate(Client client)
        {
            //TODO Update this!
            return true;
        }
    }
}
