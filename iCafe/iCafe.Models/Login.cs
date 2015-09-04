using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace iCafe.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LoginId { get; set; }

        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public string IPAddress { get; set; }
        public string MachineName { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
