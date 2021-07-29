using System.Collections.Generic;
using System.Net.Mail;
using Project.Request.Models.Extensions;

namespace Project.Request.Models.Settings
{
    public class MailAddressSettings
    {
        public string FromAddress { get; set; }
        public string FromName { get; set; }
        public string ToAddress { get; set; }
        public string ToName { get; set; }

        public List<MailAddress> GetMailAddresses()
        {
            var addresses = new List<MailAddress>();
            // if the ToAddress string is not null or empty
            if (!string.IsNullOrEmpty(ToAddress))
            {
                // split address and split names
                var toAddresses = ToAddress.Split(',');
                var toNames = ToName.Split(',');

                // add each addresses as a list
                toAddresses.Each((str, n) => { addresses.Add(new MailAddress(str.Trim(), toNames[n].Trim())); });
                // return the List of MailAddress
                return addresses;
            }

            return addresses;
        }
    }
}