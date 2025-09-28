using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ConsoleApp1.Models
{

    public class User
    {
        [Key]
        public int userid { get; set; }
        public string username { get; set; }
        public string email { get; set; }

        public int age { get; set; }
    }

}
