using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class KhoHangBLL
    {
        KhoHangDAL khdal = new KhoHangDAL();

        public DataTable LoadKhoHang()
        {
            return khdal.LoadKhoHang();
        }

        public void XoaKhoHang(string maKho)
        {
            khdal.XoaKhoHang(maKho);
        }
    }
}
