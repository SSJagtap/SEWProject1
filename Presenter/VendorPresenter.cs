using SEWProject1.Model;
using System.Collections.Generic;

namespace SEWProject1.Presenter
{
    class VendorPresenter
    {
        VendorModel vendorProvider = new VendorModel();
        public List<VendorModel> Getvendor()
        {
            var vendordata = vendorProvider.get();
            return vendordata;
        }
        public int getcnt()
        {
            int j = vendorProvider.getcount();
            return j;
        }
    }
}
