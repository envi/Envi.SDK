using System;

namespace Api.Common.Entities.Vendors.DTO
{
	/// <summary>
	/// Class that describes Vendor.
	/// </summary>
	public class Vendor
	{
		/// <summary>
		/// Get or set the Vendor Id value.
		/// </summary>
		public Guid VendorId { get; set; }

		/// <summary>
		/// Get or set the Vendor no value.
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Get or set the name of the Vendor.
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Get or set the Organization Id value.
		/// </summary>
		public Guid OrganizationId { get; set; }

		/// <summary>
		/// Get or set the Organization no value.
		/// </summary>
		public string OrganizationNo { get; set; }

		/// <summary>
		/// Get or set the name of the Organization.
		/// </summary>
		public string OrganizationName { get; set; }

		/// <summary>
		/// Get or set the Vendor notes value.
		/// </summary>
		public string VendorNotes { get; set; }

		/// <summary>
		/// Get the Vendor date added.
		/// </summary>
		public DateTime? DateAdded { get; set; }

		/// <summary>
		/// Get the Vendor added by Id.
		/// </summary>
		public Guid? AddedBy { get; set; }

		/// <summary>
		/// Get the name of the Vendor added by.
		/// </summary>
		public string AddedByName { get; set; }

		/// <summary>
		/// Get the Vendor last updated date.
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Get the Vendor last updated by Id.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get the last name of the Vendor updated by.
		/// </summary>
		public string LastUpdatedByName { get; set; }

		/// <summary>
		/// Get or set active status for Vendor.
		/// </summary>
		public bool ActiveStatus { get; set; }

		/// <summary>
		/// Get or set the URL value.
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// Get or set the name of the System Vendor.
		/// </summary>
		public string SystemVendorName { get; set; }

		/// <summary>
		/// Get or set the EDI Vendor no value.
		/// </summary>
		public string EDIVendorNo { get; set; }
	}
}
