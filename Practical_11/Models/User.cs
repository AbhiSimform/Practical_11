using System.ComponentModel.DataAnnotations;

namespace Practical_11.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		[DataType(dataType: DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public string DOB { get; set; }


		public string Address { get; set; }

	}
}