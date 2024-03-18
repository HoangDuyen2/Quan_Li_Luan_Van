using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class TaiKhoan
    {
        private string username;
        private string password;
        private string chucVu;
        public TaiKhoan(string username, string password, string chucVu)
        {
            this.username = username;
            this.password = password;
            this.chucVu = chucVu;
        }
        public string getUsername() { return username; }
        public string getPassword() { return password; }
        public string getChucVu() {  return chucVu; }
    }
}
