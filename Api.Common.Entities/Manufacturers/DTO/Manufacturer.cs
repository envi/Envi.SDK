using System;

namespace Api.Common.Entities.Manufacturers.DTO
{
	/// <summary>
	/// Class that describes Manufacturer.
	/// </summary>
	public class Manufacturer
	{
		/// <summary>
		/// Gets or sets the organization Id value.
		/// </summary>
		public Guid? OrganizationId { get; set; }
		/// <summary>
		/// Gets or sets the organization no value.
		/// </summary>
		public string OrganizationNo { get; set; }
		/// <summary>
		/// Gets or sets the name of the organization.
		/// </summary>
		public string OrganizationName { get; set; }
		/// <summary>
		/// Gets or sets the manufacturer Id value.
		/// </summary>
		public Guid? ManufacturerId { get; set; }
		/// <summary>
		/// Gets or sets the manufacturer no value.
		/// </summary>
		public string ManufacturerNo { get; set; }
		/// <summary>
		/// Gets or sets the name of the manufacturer.
		/// </summary>
		public string ManufacturerName { get; set; }
		/// <summary>
		/// Gets or sets a active status of manufacturer.
		/// </summary>
		public bool? ActiveStatus { get; set; }
		/// <summary>
		/// Gets or sets the date created.
		/// </summary>
		public DateTime? DateCreated { get; set; }
		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		public Guid? CreatedBy { get; set; }
		/// <summary>
		/// Gets or sets the name of the created by.
		/// </summary>
		public string CreatedByName { get; set; }
		/// <summary>
		/// Gets or sets the last updated.
		/// </summary>
		public DateTime? LastUpdated { get; set; }
		/// <summary>
		/// Gets or sets the last updated by.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }
		/// <summary>
		/// Gets or sets the last name of the updated by.
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}
