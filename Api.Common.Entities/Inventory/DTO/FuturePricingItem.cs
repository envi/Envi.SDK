using System;

namespace Api.Common.Entities.Inventory.DTO
{
	public class FuturePricing
	{
		/// <summary>
		/// Get or set the Future Pricing Id value.
		/// </summary>
		public Guid? FuturePricingId { get; set; }

		/// <summary>
		/// Get or set the Inventory Id value.
		/// </summary>
		public Guid? InventoryId { get; set; }

		/// <summary>
		/// Get or set the Inventory no value.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Get or set the Vendor Item no value.
		/// </summary>
		public string VendorItemNo { get; set; }

		/// <summary>
		/// Get or set the Facility Id value.
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Get or set the Vendor Id value.
		/// </summary>
		public Guid? VendorId { get; set; }

		/// <summary>
		/// Get or set the Organization Id value.
		/// </summary>
		public Guid? OrganizationId { get; set; }

		/// <summary>
		/// Get or set the Organization no value.
		/// </summary>
		public string OrganizationNo { get; set; }

		/// <summary>
		/// Get or set the name of the Organization.
		/// </summary>
		public string OrganizationName { get; set; }

		/// <summary>
		/// Get or set the Vendor UOM value.
		/// </summary>
		public string VendorUOM { get; set; }

		/// <summary>
		/// Get or set the Vendor conversion factor value.
		/// </summary>
		public int? VendorConversionFactor { get; set; }

		/// <summary>
		/// Get or set the Contract no value.
		/// </summary>
		public string ContractNo { get; set; }

		/// <summary>
		/// Get or set the Contract expiration date value.
		/// </summary>
		public DateTime? ContractExpDate { get; set; }

		/// <summary>
		/// Get or set the price change date.
		/// </summary>
		public DateTime? PriceChangeDate { get; set; }

		/// <summary>
		/// Get or set the new price value.
		/// </summary>
		public decimal? NewPrice { get; set; }

		/// <summary>
		/// Get or set the price change status.
		/// </summary>
		public byte? PriceChangeStatus { get; set; }

		/// <summary>
		/// Get or set the name of the price change status.
		/// </summary>
		public string PriceChangeStatusName { get; set; }

		/// <summary>
		/// Get the facility date added.
		/// </summary>
		public DateTime? DateAdded { get; set; }

		/// <summary>
		/// Get the facility added Id value.
		/// </summary>
		public Guid? AddedBy { get; set; }

		/// <summary>
		/// Get the facility last updated date.
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Get the facility last updated by Id date.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get or set the Vendor no date.
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Get or set the name of the Vendor.
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Get or set the Facility no value.
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Get or set the name of the Facility.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Get or set the name of the facility added by.
		/// </summary>
		public string AddedByName { get; set; }

		/// <summary>
		/// Get or set the last name of the facility updated by.
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}
