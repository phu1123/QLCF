using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string CMND { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime WorkSince { get; set; }
        public bool Position { get; set; }
    }
}
