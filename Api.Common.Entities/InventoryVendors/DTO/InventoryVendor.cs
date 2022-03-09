using System;

namespace Api.Common.Entities.InventoryVendors.DTO
{
	public class InventoryVendor
	{
		/// <summary>
		/// Unique identifier of the Inventory Vendor item 
		/// </summary>
		public Guid? InventoryVendorId { get; set; }

		/// <summary>
		/// Unique identifier of the Inventory item 
		/// </summary>
		public Guid? InventoryId { get; set; }

		/// <summary>
		/// Inventory number
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Unique identifier of the Vendor
		/// </summary>
		public Guid? VendorId { get; set; }

		/// <summary>
		/// Vendor No
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Vendor Name
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Unique identifier of the Facility item to which the Vendor item is assigned.
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Facility No
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Facility Name
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Vendor item number
		/// </summary>
		public string VendorItemNo { get; set; }

		/// <summary>
		/// Vendor UOM value
		/// </summary>
		public string VendorUOM { get; set; }

		/// <summary>
		/// Vendor Conversion Factor value
		/// </summary>
		public int? VendorConversionFactor { get; set; }

		/// <summary>
		/// Vendor Cost
		/// </summary>
		public decimal? VendorCost { get; set; }

		/// <summary>
		/// Holds Vendor Priority value
		/// </summary>
		public int? VendorPriority { get; set; }

		/// <summary>
		/// Contract No
		/// </summary>
		public string ContractNo { get; set; }

		/// <summary>
		/// Contract Expiration Date
		/// </summary>
		public DateTimeOffset? ContractExpDate { get; set; }

		/// <summary>
		/// Manufacturer item number
		/// </summary>
		public string ManufacturerItemNo { get; set; }

		/// <summary>
		/// Manufacturer identifier
		/// </summary>
		public Guid? ManufacturerId { get; set; }

		/// <summary>
		/// Manufacturer No
		/// </summary>
		public string ManufacturerNo { get; set; }

		/// <summary>
		/// Manufacturer Name
		/// </summary>
		public string ManufacturerName { get; set; }

		/// <summary>
		/// GTIN
		/// </summary>
		public string GTIN { get; set; }

		/// <summary>
		/// Date the cost was last updated.
		/// </summary>
		public DateTimeOffset? CostLastUpdated { get; set; }

		/// <summary>
		/// User who last updated the cost.
		/// </summary>
		public Guid? CostLastUpdatedBy { get; set; }

		/// <summary>
		/// Date this record was first inserted.
		/// </summary>
		public DateTimeOffset? DateAdded { get; set; }

		/// <summary>
		/// Indicates which user inserted this record.
		/// </summary>
		public Guid? AddedBy { get; set; }

		/// <summary>
		/// Date this record was last updated.
		/// </summary>
		public DateTimeOffset? LastUpdated { get; set; }

		/// <summary>
		/// Indicates which user last updated this record.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Value representing status of this Inventory Location item. 
		/// If this Inventory Location item is active value is True, 
		/// otherwise - False.
		/// </summary>
		public bool? ActiveStatus { get; set; }

		/// <summary>
		/// NDC Number
		/// </summary>
		public string NDCNumber { get; set; }

		/// <summary>
		/// Lock Cost
		/// </summary>
		public bool? LockCost { get; set; }

		/// <summary>
		/// Username that reflects the user who was the last to update the cost.
		/// </summary>
		public string CostLastUpdatedByUserName { get; set; }

		/// <summary>
		/// Indicates which user inserted this record (username).
		/// </summary>
		public string AddedByUserName { get; set; }

		/// <summary>
		/// Indicates who was the last to update the record (username).
		/// </summary>
		public string LastUpdatedByUserName { get; set; }

		/// <summary>
		/// Gets or sets PIM Key
		/// </summary>
		public string PIMKey { get; set; }

		/// <summary>
		/// Gets or sets Alt Item Number
		/// </summary>
		public string AltItemNo { get; set; }
	}
}
