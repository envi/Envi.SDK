using System;

namespace Api.Common.Entities.Adjustments.DTO
{
	/// <summary>
	/// Class that describes Adjustment Item
	/// </summary>
	public class AdjustmentItem
	{
		/// <summary>
		/// Get or set the adjustment item Id value.
		/// </summary>
		public Guid? AdjustmentItemId { get; set; }

		/// <summary>
		/// Get or set the adjustment Id value.
		/// </summary>
		public Guid? AdjustmentId { get; set; }

		/// <summary>
		/// Get or set the inventory location Id value.
		/// </summary>
		public Guid? InventoryLocationId { get; set; }

		/// <summary>
		/// Get or set notes value.
		/// </summary>
		public string Notes { get; set; }

		/// <summary>
		/// Get or set the tracking lot no value.
		/// </summary>
		public string LotNo { get; set; }

		/// <summary>
		/// Get or set the tracking serial no value.
		/// </summary>
		public string SerialNo { get; set; }

		/// <summary>
		/// Get or set the tracking expiration date value.
		/// </summary>
		public DateTime? ExpDate { get; set; }

		/// <summary>
		/// Get the adjustment item date created.
		/// </summary>
		public DateTime? DateCreated { get; set; }
		
		/// <summary>
		/// Gets the adjustment item creator Id value.
		/// </summary>
		public Guid? CreatedBy { get; set; }

		/// <summary>
		/// Get the name of facility creator.
		/// </summary>
		public string CreatedByName { get; set; }

		/// <summary>
		/// Gets the last updated date.
		/// </summary>
		public DateTime? LastUpdated { get; set; }
		
		/// <summary>
		/// Gets the last updated Id.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get or set the name of the last facility updator.
		/// </summary>
		public string LastUpdatedByName { get; set; }

		/// <summary>
		/// Get or set the adjustment item line no value.
		/// </summary>
		public int? LineNo { get; set; }

		/// <summary>
		/// Get or set the name of the facility.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Get or set the name of the location.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Get or set the date submitted.
		/// </summary>
		public DateTime? DateSubmitted { get; set; }

		/// <summary>
		/// Get or set the inventory no value.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Get or set the inventory description.
		/// </summary>
		public string InventoryDescription { get; set; }

		/// <summary>
		/// Get or set the name of the classification.
		/// </summary>
		public string ClassificationName { get; set; }

		/// <summary>
		/// Get or set the name of the vendor.
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Get or set the vendor item no value.
		/// </summary>
		public string VendorItemNo { get; set; }

		/// <summary>
		/// Get or set the quantity.
		/// </summary>
		public int? Quantity { get; set; }

		/// <summary>
		/// Get or set the impact quantity value.
		/// </summary>
		public int? ImpactQuantity { get; set; }

		/// <summary>
		/// Get or set the UOM value.
		/// </summary>
		public string UOM { get; set; }

		/// <summary>
		/// Get or set the conversion factor value.
		/// </summary>
		public int? ConversionFactor { get; set; }

		/// <summary>
		/// Get or set the adjustment type value.
		/// </summary>
		public string AdjustmentTypeText { get; set; }

		/// <summary>
		/// Get or set the unit cost value.
		/// </summary>
		public decimal? UnitCost { get; set; }

		/// <summary>
		/// Get or set the extended cost value.
		/// </summary>
		public decimal? ExtendedCost { get; set; }
	}
}