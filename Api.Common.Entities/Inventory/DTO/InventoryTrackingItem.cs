using System;

namespace Api.Common.Entities.Inventory.DTO
{
	public class InventoryTrackingItem 
	{
		/// <summary>
		/// Unique identifier of this Inventory Location item.
		/// </summary>
		public Guid? InventoryTrackingItemId { get; set; }

		/// <summary>
		/// Unique identifier of the Inventory item 
		/// location of which is reflected by this Inventory Location item.
		/// </summary>
		public Guid? InventoryId { get; set; }

		/// <summary>
		/// Inventory No value
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// stock UOM
		/// </summary>
		public string StockUOM { get; set; }

		/// <summary>
		/// Unique identifier of the Facility item to which the Location item, reflecting location of the Inventory item
		/// specified by 'InventoryId', is assigned.
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Facility No value
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Name of the Facility item to which the Location item, reflecting location of the Inventory item
		/// specified by 'InventoryId', is assigned.
		/// </summary>
		public string FacilityName { get; set; }

		public Guid? InventoryLocationId { get; set; }

		/// <summary>
		/// Facility No value
		/// </summary>
		public string LocationNo { get; set; }

		/// <summary>
		/// Name of the Facility item to which the Location item, reflecting location of the Inventory item
		/// specified by 'InventoryId', is assigned.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Lot
		/// </summary>
		public string Lot { get; set; }

		/// <summary>
		/// ExpirationDate
		/// </summary>
		public DateTime? ExpirationDate { get; set; }

		/// <summary>
		/// SerialNo
		/// </summary>
		public string SerialNo { get; set; }

		/// <summary>
		/// Quantity
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// Date this record was first inserted.
		/// </summary>
		public DateTime? DateAdded { get; set; }

		/// <summary>
		/// Indicates which user inserted this record.
		/// </summary>
		public Guid? AddedBy { get; set; }

		/// <summary>
		/// Added By Name
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
		/// Last Updated By Name
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}
