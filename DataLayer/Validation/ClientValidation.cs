using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Common;
using DataLayer.DataAccess;
using System.Text.RegularExpressions;

namespace DataLayer.Validation
{
    public class ClientValidation
    {
        /// <summary>
        /// Adds New Client, returs list containing errors messages (if any), empty if add success
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<string> AddClient(Client client)
        {
            List<string> errorList = validate(client, true);
            if (errorList.Count == 0)
            {
                int rowsAffected = ClientRepository.AddClient(client);
                if (rowsAffected == 0)
                {
                    //To make sure errors aren't lost if no rows were actually added
                    errorList.Add("Error creating client.  Please try again later.");
                }
                return errorList;
            }
            else
            {
                return errorList;
            }
        }

        /// <summary>
        /// Updates Client, returs list containing errors messages (if any), empty if update success
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<string> UpdateClient(Client client)
        {
            List<string> errorList = validate(client, false);
            if (errorList.Count == 0)
            {
                int rowsAffected = ClientRepository.UpdateClient(client);
                if (rowsAffected == 0)
                {
                    //To make sure errors aren't lost if no rows were actually changed
                    errorList.Add("Error updating client.  Please try again later.");
                }
                return errorList;
            }
            else
            {
                return errorList;
            }
        }

        private static List<string> validate(Client client, bool IsNew)
        {

            List<string> errorList = new List<string>();

            if (IsNew)
            {
                if (DataAccess.ClientRepository.GetClients().Where(x => x.ClientCode == client.ClientCode).Count() > 0)
                {
                    errorList.Add("Client Code already in use.");
                }
            }

            if (String.IsNullOrWhiteSpace(client.ClientCode))
            {
                errorList.Add("Client Code cannot be blank");
            }
            else
            {
                string regExClientCode = @"^[A-Z]{5}$";
                if (!Regex.IsMatch(client.ClientCode, regExClientCode))
                {
                    errorList.Add("Client Code must be 5 upper case letters");
                }
            }

            if (String.IsNullOrWhiteSpace(client.CompanyName))
            {
                errorList.Add("Company Name cannot be blank");
            }

            if (String.IsNullOrWhiteSpace(client.Address1))
            {
                errorList.Add("Address cannot be blank");
            }

            if (String.IsNullOrWhiteSpace(client.Province))
            {
                errorList.Add("Province cannot be blank");
            }

            if (String.IsNullOrWhiteSpace(client.PostalCode))
            {
                errorList.Add("Postal Code cannot be blank");
            }
            else
            {
                string regExCdnPostalCode = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";
                if (!Regex.IsMatch(client.PostalCode, regExCdnPostalCode))
                {
                    errorList.Add("Postal Code must be formatted like: A1A 1A1");
                }

            }


            if (client.YtdSales < 0)
            {
                errorList.Add("Year to Date Sales cannot be less than 0");
            }

            return errorList;
        }
    }
}
