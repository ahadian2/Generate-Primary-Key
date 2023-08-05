using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GenratePrimeryKey.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserEmail { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserPassword { get; set; }
    }
}