﻿using OES.Model.Examination;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OES.Model.Users
{
    public class Student : User
    {
        public Student()
            : base()
        {
            Role = UserRole.Student;
        }

        [Required]
        public DateTime BirthDate { get; set; }

        [NotMapped]
        public int Age {
            get {
                return (DateTime.Now.Year - BirthDate.Year);
            }
        }
        public List<StudentRegistration> Registrations { get; set; }

    }
}
