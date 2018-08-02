using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestUserCRUD.Model
{
    public class TestUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public int MobileNo { get; set; }
    }
}
