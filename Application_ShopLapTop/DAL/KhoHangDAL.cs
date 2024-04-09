using DAL.QLShoplaptopTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoHangDAL
    {
        KHOHANGTableAdapter da_KhoHang = new KHOHANGTableAdapter();

        public KhoHangDAL()
        {

        }

        public void XoaKhoHang(string maKho)
        {
            QLShoplaptop.KHOHANGRow rowToDelete = da_KhoHang.GetData().FindByMaKho(maKho);

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                da_KhoHang.Update(rowToDelete);
            }
        }

        public System.Data.DataTable LoadKhoHang()
        {
            DataTable dataTable = new DataTable();
            dataTable = da_KhoHang.GetData();
            return dataTable;
        }
    }
}
