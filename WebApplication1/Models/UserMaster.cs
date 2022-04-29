using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Table("UserMaster")]
    public partial class UserMaster
    {
        [Key]
        public int Uid { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Name { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? UserId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Password { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        public int? Role { get; set; }
        [Column("createdon", TypeName = "datetime")]
        public DateTime? Createdon { get; set; }
    }
}
