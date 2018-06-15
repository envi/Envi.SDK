using System;

namespace Api.Common.Entities.InventoryLocations.DTO
{
	/// <summary>
	/// Class representing Inventory Cost Layer item on server side of application.
	/// </summary>
	public class CostLayer
	{
		/// <summary>
		/// Inventory Cost Layer Id value
		/// </summary>
		public string CostLayerId { get; set; }

		/// <summary>
		/// Inventory Location identifier
		/// </summary>
		public string InventoryLocationId { get; set; }

		/// <summary>
		/// Location Name
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Location No
		/// </summary>
		public string LocationNo { get; set; }

		/// <summary>
		/// Quantity
		/// </summary>
		public int? Quantity { get; set; }

		/// <summary>
		/// Cost
		/// </summary>
		public decimal? Cost { get; set; }
		
		/// <summary>
		/// Date Created date
		/// </summary>
		public DateTime? DateCreated { get; set; }

		/// <summary>
		/// Created By User Name
		/// </summary>
		public string CreatedByUserName { get; set; }
		
		/// <summary>
		/// Last Updated By User Name
		/// </summary>
		public string LastUpdatedByUserName { get; set; }

		/// <summary>
		/// Last Updated  By User Id
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Created By User Id
		/// </summary>
		public Guid? CreatedBy { get; set; }

		/// <summary>
		/// Last updated date
		/// </summary>
		public DateTime? LastUpdated { get; set; }
	}
}