namespace Api.Common.Entities.Inventory.DTO
{
	public class POHistoryItem
	{
		/// <summary>
		/// Id of poHistory record 
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Name of month entry
		/// </summary>
		public string MonthName { get; set; }

		/// <summary>
		/// Number of month entry
		/// </summary>
		public int MonthNumber { get; set; }

		/// <summary>
		/// Quantity of items ordered in selected month
		/// </summary>
		public long? QuantityOrdered { get; set; }

		/// <summary>
		/// Number of purchase orders this inventory was ordered 
		/// </summary>
		public int NumberOfPOs { get; set; }

		/// <summary>
		/// Total cost of items ordered in selected month
		/// </summary>
		public decimal TotalCost { get; set; }

		/// <summary>
		/// Facility Name
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Year
		/// </summary>
		public int Year { get; set; }

	}
}
