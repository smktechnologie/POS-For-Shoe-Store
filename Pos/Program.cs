using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public class ProductDetails
    {
        public ProductDetails(int _Quantity, double _Price, double _Total, int _RemainingQuantity)
        {
            Quantity = _Quantity;
            Price = _Price;
            Total = _Total;
            RemainingQuantity = _RemainingQuantity;
        }

        public int Quantity;
        public double Price;
        public double Total;
        public int RemainingQuantity;
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login frmlogin = new Login();

            Application.Run(frmlogin);
            if (frmlogin.UserSuccessfullyAuthenticated && frmlogin.IsUserAdmin)
            {
                Application.Run(new Home());
            }


            // Application.Run(new Home());
        }
    }
}
