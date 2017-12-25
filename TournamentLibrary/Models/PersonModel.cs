﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// unique ID of person
        /// </summary>
        public int PersonID { get; set; }
        /// <summary>
        /// Person's first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Person's last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Person's email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Person's cntact number
        /// </summary>
        public string ContactNumber { get; set; }
        /// <summary>
        /// Person's sex
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// Person's age
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Team person plays for
        /// </summary>
        public TeamModel Team { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public PersonModel()
        {

        }

        public PersonModel(string firstName, String lastName, String email, string contactNumber, string sex, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            ContactNumber = contactNumber;
            Sex = sex;
            DateOfBirth = dateOfBirth;
        }


    }
}
