namespace Models
{
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Range
			(type: typeof(int), minimum: "25", maximum: "35")]
		public int Age { get; set; }
		// **********

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 6)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 8)]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 40, MinimumLength = 40)]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50, MinimumLength = 3)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]
		public string FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250, MinimumLength = 5)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string EmailAddress { get; set; }
		// **********
	}
}
