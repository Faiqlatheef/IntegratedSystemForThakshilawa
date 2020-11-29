using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystemThakshilawa
{
    class routesForms
    {
        public static void moveToIndex()
        {
            index ind = new index();
            ind.Show();
        }

        public static void moveToLogin()
        {
            Login login = new Login();
            login.Show();
        }

        public static void moveToAdminPanel()
        {
            adminPanel ad = new adminPanel();
            ad.Show();
        }

        public static void moveToOwnerPanel()
        {
            ownerPanel op = new ownerPanel();
            op.Show();
        }

        public static void moveToHRPanel()
        {
            hrPanel hp = new hrPanel();
            hp.Show();
        }

        public static void moveToManagerPanel()
        {
            managerPanel mp = new managerPanel();
            mp.Show();
        }
    }
}
