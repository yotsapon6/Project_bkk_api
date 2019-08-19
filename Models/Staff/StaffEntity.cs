﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class StaffEntity
    {
        [Key]
        public Guid id { get; set; }

        [MaxLength(255)]
        public string firstname { get; set; }

        [MaxLength(255)]
        public string lastname { get; set; }

        [MaxLength(255)]
        public string position { get; set; }

        [MaxLength(255)]
        public string username { get; set; }

        [MaxLength(255)]
        public string password { get; set; }

        [MaxLength(255)]
        public string email { get; set; }

        [MaxLength(255)]
        public string tel { get; set; }

        public bool is_active { get; set; }

        public Guid? created_by { get; set; }

        public DateTime? created_at { get; set; }

        public Guid? updated_by { get; set; }

        public DateTime? updated_at { get; set; }

        public DateTime? deleted_at { get; set; }
    }
}
