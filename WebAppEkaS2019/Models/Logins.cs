namespace WebAppEkaS2019.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Logins
    {
        public int LoginId { get; set; }
        [Required(ErrorMessage = "Anna käyttäjätunnus!")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Anna salasana!")]
        public string PassWord { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}