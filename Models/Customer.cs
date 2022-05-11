using System;
using System.ComponentModel.DataAnnotations;

namespace Bank_Aldi.Models
{
	public class Customer
	{
		[Key]
		public String NIK { get; set; }
		public String? FirstName { get; set; }
		public String? LastName { get; set; }
		public String? BirthPlace { get; set; }
		public DateTime? BirthOfDate { get; set; }
		public Int64? PhoneNumber { get; set; }
		public bool isDelete { get; set; } = false;

        #region Address
        public String? Street { get; set; }
		public String? City { get; set; }
        #endregion
    }
}

