using System;

namespace Api.Common.Entities.InventoryVendors.DTO
{
	public class InventoryVendorPurchasingUnit
	{
		/// <summary>
		/// Unique identifier of InventoryVendorPurchasingUnit
		/// </summary>
		public Guid? InventoryVendorPurchasingUnitId { get; set; }

		/// <summary>
		/// Inventory Vendor primary key
		/// </summary>
		public Guid? InventoryVendorId { get; set; }

		/// <summary>
		/// Vendor name
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Vendor No
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// UOM value
		/// </summary>
		public string VendorUOM { get; set; }

		/// <summary>
		/// Inventory Vendor Cost Conversion Factor value
		/// </summary>
		public int? VendorConversionFactor { get; set; }

		/// <summary>
		/// Cost value
		/// </summary>
		public decimal? VendorCost { get; set; }

		/// <summary>
		/// Active Status
		/// </summary>
		public bool? ActiveStatus { get; set; }

		/// <summary>
		/// Last vendor cost value
		/// </summary>
		public decimal? LastVendorCost { get; set; }

		/// <summary>
		/// Inventory Vendor Cost date updated
		/// </summary>
		public DateTime? CostLastUpdated { get; set; }

		/// <summary>
		/// Inventory Vendor Cost updated user Id
		/// </summary>
		public Guid? CostLastUpdatedBy { get; set; }

		/// <summary>
		/// Inventory Vendor Cost updated user name
		/// </summary>
		public string CostLastUpdatedByName { get; set; }

		/// <summary>
		/// Date this record was first inserted.
		/// </summary>
		public DateTime? DateAdded { get; set; }

		/// <summary>
		/// Indicates which user inserted this record.
		/// </summary>
		public Guid? AddedBy { get; set; }

		/// <summary>
		/// Indicates  user name who inserted this record.
		/// </summary>
		public string AddedByName { get; set; }

		/// <summary>
		/// Date this record was last updated.
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Indicates which user last updated this record.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Indicates  user name who last updated this record.
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}