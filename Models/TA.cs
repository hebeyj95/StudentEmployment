using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaconsaleMovieCollection.Models
{
    public class TA
    {
        [Key]
        [Required]
        public int TaId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public bool International { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string ExpectedHours { get; set; }
        public string Semester { get; set; }
        public int Year { get; set; }
        public string Phone { get; set; }
        public int ByuId { get; set; }
        public string PositionType { get; set; }
        public int ClassCode { get; set; }
        public int EmplRecord { get; set; }
        public DateTime HireDate { get; set; }
        public double PayRate { get; set; }
        public DateTime LastPayIncDate { get; set; }
        public double PayIncAmount { get; set; }
        public DateTime IncreaseInputDate { get; set; }
        public string ProgramYear { get; set; }
        public bool GradTuition { get; set; }
        public bool NameChangeComplete { get; set; }
        public string Notes { get; set; }
        public bool Terminated { get; set; }
        public DateTime TerminationDate { get; set; }
        public string QualtricsSurveySent { get; set; }
        public bool FormSubmit { get; set; }
        public DateTime FormSubmitDate { get; set; }
        public bool AuthorizationWork { get; set; }
        public DateTime AuthorizeWorkSendDate { get; set; }
        public string ByuName { get; set; }
    }
}
