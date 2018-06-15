using System;

namespace Api.Common.Entities.Addresses.DTO
{
	/// <summary>
	/// Class that describes Addresses
	/// </summary>
	public class Address
	{
		/// <summary>
		/// Get or set the address Id value.
		/// </summary>
		public Guid? AddressId { get; set; }
		/// <summary>
		/// Get or set the organization Id value.
		/// </summary>
		public Guid? OrganizationId { get; set; }

		/// <summary>
		/// Get or set the organization no value.
		/// </summary>
		public string OrganizationNo { get; set; }

		/// <summary>
		/// Get or set the name of the organization.
		/// </summary>
		public string OrganizationName { get; set; }

		/// <summary>
		/// Get or set the address no value.
		/// </summary>
		public string AddressNo { get; set; }

		/// <summary>
		/// Get or set the name of the address.
		/// </summary>
		public string AddressName { get; set; }

		/// <summary>
		/// Get or set the address type Id.
		/// </summary>
		public byte? AddressTypeId { get; set; }

		/// <summary>
		/// Get or set the type of the address.
		/// </summary>
		public string AddressType { get; set; }

		/// <summary>
		/// Get or set the facility Id value.
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Get or set the facility no value.
		/// </summary>
		public string FacilityNo { get; set; }
		
		/// <summary>
		/// Get or set the name of the facility.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Gets or sets the address description value.
		/// </summary>
		public string AddressDescription { get; set; }
		
		/// <summary>
		/// Get or set the address1.
		/// </summary>
		public string Address1 { get; set; }
		
		/// <summary>
		/// Get or set the address2.
		/// </summary>
		public string Address2 { get; set; }
		
		/// <summary>
		/// Get or set the city.
		/// </summary>
		public string City { get; set; }
		
		/// <summary>
		/// Get or set the state.
		/// </summary>
		public string State { get; set; }
		
		/// <summary>
		/// Get or set the zip.
		/// </summary>
		public string Zip { get; set; }
		
		/// <summary>
		/// Get or set the country.
		/// </summary>
		public string Country { get; set; }
		
		/// <summary>
		/// Get or set the name of the contact.
		/// </summary>
		public string ContactName { get; set; }

		/// <summary>
		/// Get or set the contact email value.
		/// </summary>
		public string ContactEmail { get; set; }
		/// <summary>
		/// Get or set the phone value.
		/// </summary>
		public string Phone { get; set; }

		/// <summary>
		/// Get or set the phone extention value.
		/// </summary>
		public string PhoneExt { get; set; }

		/// <summary>
		/// Get or set the fax value.
		/// </summary>
		public string Fax { get; set; }
		
		/// <summary>
		/// Get or set a value indicating whether this address is default.
		/// </summary>
		public bool? IsDefaultAddress { get; set; }
		
		/// <summary>
		/// Get or set active status of address.
		/// </summary>
		public bool? ActiveStatus { get; set; }
		
		/// <summary>
		/// Get the date created of addresss.
		/// </summary>
		public DateTime? DateCreated { get; set; }
		
		/// <summary>
		/// Gets the creator Id.
		/// </summary>
		public Guid? CreatedBy { get; set; }
		
		/// <summary>
		/// Gets the name of the address creator.
		/// </summary>
		public string CreatedByName { get; set; }
		
		/// <summary>
		/// Get the last updated date.
		/// </summary>
		public DateTime? LastUpdated { get; set; }
		
		/// <summary>
		/// Get the last updated Id.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get the name of the last updater.
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}
