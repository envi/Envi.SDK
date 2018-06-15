using System;

namespace Api.Common.Entities.Locations.DTO
{
	/// <summary>
	/// Class that describes Location.
	/// </summary>
	public class Location
	{
		/// <summary>
		/// Get or set the location Id value.
		/// </summary>
		public Guid LocationId { get; set; }

		/// <summary>
		/// Get or set the location no value.
		/// </summary>
		public string LocationNo { get; set; }
		
		/// <summary>
		/// Get or set the name of the location.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Get or set the facility Id value.
		/// </summary>
		public Guid FacilityId { get; set; }

		/// <summary>
		/// Get the facility no value.
		/// </summary>
		public string FacilityNo { get; set; }
		
		/// <summary>
		/// Get the name of the facility.
		/// </summary>
		public string FacilityName { get; set; }
		
		/// <summary>
		/// Get or set the default billing address identifier.
		/// </summary>
		public Guid DefaultBillingAddressId { get; set; }
		
		/// <summary>
		/// Get or set the default billing address no.
		/// </summary>
		public string DefaultBillingAddressNo { get; set; }
		
		/// <summary>
		/// Get the default name of the billing address.
		/// </summary>
		public string DefaultBillingAddressName { get; set; }

		/// <summary>
		/// Get or set the default shipping address Id value.
		/// </summary>
		public Guid DefaultShippingAddressId { get; set; }

		/// <summary>
		/// Get the default shipping address no value.
		/// </summary>
		public string DefaultShippingAddressNo { get; set; }

		/// <summary>
		/// Get or set the default name of the shipping address value.
		/// </summary>
		public string DefaultShippingAddressName { get; set; }

		/// <summary>
		/// Get or set the gl code value.
		/// </summary>
		public string GLCode { get; set; }
		
		/// <summary>
		/// Get or set a active status value of location.
		/// </summary>
		public bool ActiveStatus { get; set; }

		/// <summary>
		/// Get or set a default synchronize flag value.
		/// </summary>
		public bool DefaultSyncFlag { get; set; }
		
		/// <summary>
		/// Get the date created of location.
		/// </summary>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Get the location creator Id value.
		/// </summary>
		public Guid CreatedBy { get; set; }
		
		/// <summary>
		/// Get the name of the location creator.
		/// </summary>
		public string CreatedByName { get; set; }
		
		/// <summary>
		/// Get the last updated date of location.
		/// </summary>
		public DateTime LastUpdated { get; set; }
		
		/// <summary>
		/// Get the last updated Id of location.
		/// </summary>
		public Guid LastUpdatedBy { get; set; }
		
		/// <summary>
		/// Get the  name of the last updated of location.
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}