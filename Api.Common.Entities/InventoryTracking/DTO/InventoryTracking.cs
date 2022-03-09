using System;

namespace Api.Common.Entities.InventoryTracking.DTO
{
	/// <summary>
	/// Class that describes Inventory Tracking.
	/// </summary>
	public class InventoryTracking
	{
		/// <summary>
		/// Gets or sets the inventory tracking Id value.
		/// </summary>
		public Guid? InventoryTrackingId { get; set; }

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

		/// <summary>
		/// TrackLot
		/// </summary>
		public bool TrackLot { get; set; }

		/// <summary>
		/// TrackExpiration
		/// </summary>
		public bool TrackExpiration { get; set; }

		/// <summary>
		/// TrackSerialNo
		/// </summary>
		public bool TrackSerialNo { get; set; }

		/// <summary>
		/// IsOptional
		/// </summary>
		public bool IsOptional { get; set; }

		/// <summary>
		/// Date this record was first inserted.
		/// </summary>
		public DateTimeOffset? DateAdded { get; set; }

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
		public DateTimeOffset? LastUpdated { get; set; }

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
