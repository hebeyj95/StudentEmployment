using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaconsaleMovieCollection.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
        [Required]
        public string FirstName { get; set;}
        [Required]
        public string LastName { get; set;}
        [Required]
        public string International { get; set;}
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Hours { get; set;}
        [Required]
        public string Semester { get; set; }
        [Required]
        public string Phone { get; set;}
        [Required]
        public int BYUID { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public int ClassCode { get; set;}
        [Required]
        public int EmpRecord { get; set;}
        [Required]
        public string Supervisor { get; set;}
        [Required]
        public string HireDate { get; set;}
        [Required]
        public double PayRate { get; set;}
        public string LastPayIncrease { get; set;}
        public double PayIncreaseAmount { get; set;}
        public string IncreaseInputDate { get; set;}
        [Required]
        public string YearInProgram { get; set;}
        [Required]
        public string PayGradTutition { get; set;}
        public string Terminated { get; set;}
        public string TerminationDate { get; set;}
        [Required]
        public string QualtricsSurveySent { get; set;}
        [Required]
        public string SubmittedEform { get; set;}
        [Required]
        public string FormSubmissionDate { get; set;}
        [Required]
        public string AuthorizationToWork { get; set;}
        [Required]
        public string AuthorizationEmailDate { get; set;}
        [Required]
        public string BYUName { get; set;}
        [Required]
        public string NameChangeCompleted { get; set;}

        // Foreign key relationship
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
