namespace Api.Common.Entities.Inventory.DTO
{
	/// <summary>
	/// Class that describes Extended Inventory.
	/// </summary>
	public class InventoryExtended : Inventory
	{
		/// <summary>
		/// Get or set the type of the item.
		/// </summary>
		public string ItemType { get; set; }

		/// <summary>
		/// Get or set a billable value.
		/// </summary>
		public bool Billable { get; set; }
	}
}