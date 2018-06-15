using System;

namespace Api.Common.Entities.Vendors.DTO
{
	public class VendorInfo
	{
		/// <summary>
		/// Vendor PK
		/// </summary>
		public Guid? VendorId { get; set; }

		/// <summary>
		/// Vendor name
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Vendor number
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Address 1
		/// </summary>
		public string Address1 { get; set; }

		/// <summary>
		/// Address 2
		/// </summary>
		public string Address2 { get; set; }

		/// <summary>
		/// City
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// State
		/// </summary>
		public string State { get; set; }

		/// <summary>
		/// Zip
		/// </summary>
		public string Zip { get; set; }

		/// <summary>
		/// Country
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		/// URL
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		public string AccountNumber { get; set; }

		/// <summary>
		/// Active status
		/// </summary>
		public bool? ActiveStatus { get; set; }

		/// <summary>
		/// Last updated date
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Lead time
		/// </summary>
		public int? LeadTime { get; set; }
	}
}
