using System;

namespace Api.Common.Entities.Inventory.DTO
{
	public class ManagePurchasing
	{
		/// <summary>
		/// DisablePurchasing value
		/// </summary>
		public bool DisablePurchasing { get; set; }

		/// <summary>
		/// FacilityPK
		/// </summary>
		public Guid? Facility { get; set; }
	}
}
