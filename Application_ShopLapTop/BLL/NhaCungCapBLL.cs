using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL dalncc = new NhaCungCapDAL();

        public DataTable LoadNhaCungCap()
        {
            return dalncc.LoadNhaCungCap();
        }

        public void ThemNhaCungCap(NhaCungCap pNhaCungCap)
        {
            dalncc.ThemNhaCungCap(pNhaCungCap);
        }

        public void XoaNhaCungCap(string maNhaCungCap)
        {
            dalncc.XoaNhaCungCap(maNhaCungCap);
        }

        public void SuaNhaCungCap(NhaCungCap pNhaCungCap)
        {
            dalncc.SuaNhaCungCap(pNhaCungCap);
        }
    }
}
