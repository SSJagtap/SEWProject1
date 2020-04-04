using SEWProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEWProject1.View;
namespace SEWProject1.Presenter
{
    class PurchaseInvoicePresenter
    { //PurchaseInvoicedata purchaseInvoicedata = new PurchaseInvoicedata();
        PurchaseInvoiceModel purchaseProvider = new PurchaseInvoiceModel();
        public List<PurchaseInvoiceModel> Getpurchase()
        {
            var purchaseinvdata = purchaseProvider.get();
            return purchaseinvdata;
        }
        public int getcnt() 
        {
            int j = purchaseProvider.getcount();
            return j;
        }
     
    }
}
