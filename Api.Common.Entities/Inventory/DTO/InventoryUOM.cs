using System;

namespace Api.Common.Entities.Inventory.DTO
{
	/// <summary>
	/// Class that describes InventoryUOM.
	/// </summary>
	public class InventoryUOM
	{
		/// <summary>
		/// Get the inventory uom Id value.
		/// </summary>
		public Guid InventoryUOMId { get; set; }

		/// <summary>
		/// Get the inventory Id value.
		/// </summary>
		public Guid? InventoryId { get; set; }

		/// <summary>
		/// Get or sets the inventory value.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Get or sets the uom value.
		/// </summary>
		public string UOM { get; set; }

		/// <summary>
		/// Get or sets the conversion factor value.
		/// </summary>
		public int ConversionFactor { get; set; }
		
		/// <summary>
		/// Get the date added of Inventory UOM.
		/// </summary>
		public DateTime DateAdded { get; set; }
		
		/// <summary>
		/// Get the added Id of Inventory UOM.
		/// </summary>
		public Guid AddedId { get; set; }
		
		/// <summary>
		/// Get the last updated of inventory date.
		/// </summary>
		public DateTime LastUpdated { get; set; }
		
		/// <summary>
		/// Get the last updated of inventory Id.
		/// </summary>
		public Guid LastUpdatedId { get; set; }
	}
}