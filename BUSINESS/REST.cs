using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST.BUSINESS
{
    static class REST
    {
        internal static bool MoreThan10(object idGateway)
        {
            bool morethan10 = false;
            var countByGateway = UTILS.Utils.ConectarLinq().PeriphericalDevices.Count(pd=>pd.idGateway==(int)idGateway);
            if (countByGateway>10)
            {
                morethan10 = true;
            }
            return morethan10;
        }

        internal static void StoreGateway(string uniqueSerialNumTextEdit, string humanReadableTextEdit, string iPv4TextEdit)
        {
            var linq = UTILS.Utils.ConectarLinq();
            var foundIPv4 = linq.Gateways.FirstOrDefault(gat=>gat.IPv4.Equals(iPv4TextEdit));
            if (foundIPv4!=null)
            {
                MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundUnique = linq.Gateways.FirstOrDefault(gat => gat.IPv4.Equals(uniqueSerialNumTextEdit));
            if (foundUnique != null)
            {
                MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            linq.Gateways.InsertOnSubmit(new DATA.Gateway { humanReadable = humanReadableTextEdit, IPv4 = iPv4TextEdit, uniqueSerialNum = uniqueSerialNumTextEdit });
            linq.SubmitChanges();
        }
    }

}
