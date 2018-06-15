using System;

namespace Api.Common.Entities.InventoryVendors.DTO
{
	/// <summary>
	/// A class representing InventoryVendorCostHistory entity.
	/// </summary>
	public class InventoryVendorCostHistory
	{
		/// <summary>
		/// Inventory Vendor Cost History primary key
		/// </summary>
		public Guid? InventoryVendorCostHistoryId { get; set; }

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
		/// Inventory Vendor Cost primary key
		/// </summary>
		public Guid? InventoryVendorCostId { get; set; }

		/// <summary>
		/// Cost value
		/// </summary>
		public decimal? VendorCost { get; set; }

		/// <summary>
		/// UOM value
		/// </summary>
		public string VendorUOM { get; set; }

		/// <summary>
		/// Inventory Vendor Cost Conversion Factor value
		/// </summary>
		public int? VendorConversionFactor { get; set; }

		/// <summary>
		/// Inventory Vendor Cost date updated
		/// </summary>
		public DateTime? CostUpdated { get; set; }

		/// <summary>
		/// Inventory Vendor Cost updated user PK
		/// </summary>
		public Guid? CostUpdatedBy { get; set; }

		/// <summary>
		/// Inventory Vendor Cost updated user name
		/// </summary>
		public string CostUpdatedByName { get; set; }
	}
}
