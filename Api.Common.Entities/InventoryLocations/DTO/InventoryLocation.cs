using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Common.Entities.InventoryLocations.DTO
{
	public class InventoryLocation
	{
		/// <summary>
		/// Unique identifier of this Inventory Location item.
		/// </summary>
		public Guid? InventoryLocationId { get; set; }

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
		/// Name of the Facility item to which the Location item, reflecting location of the Inventory item
		/// specified by 'InventoryId', is assigned.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Facility No value
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Unique identifier of the Location item reflecting location of the Inventory item
		/// specified by 'InventoryId'.
		/// </summary>
		public Guid? LocationId { get; set; }

		/// <summary>
		/// Name of the Location item reflecting location of the Inventory item
		/// specified by 'InventoryId'.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Location No value
		/// </summary>
		public string LocationNo { get; set; }

		/// <summary>
		/// Location UOM value(field from Inventory Location details screen)
		/// </summary>
		[StringLength(2)]
		public string LocationUOM { get; set; }

		/// <summary>
		/// Inventory Location Conversion Factor value
		/// </summary>
		public int? LocationConversionFactor { get; set; }

		/// <summary>
		/// Inventory Stock UOM value
		/// </summary>
		public string InventoryStockUOM { get; set; }

		/// <summary>
		/// Default Issue UOM(field from Inventory Location details screen)
		/// </summary>
		[StringLength(2)]
		public string DefaultIssueUOM { get; set; }

		/// <summary>
		/// Default Issue Conversion Factor(field from Inventory Location details screen)
		/// </summary>
		public int? DefaultIssueConversionFactor { get; set; }

		/// <summary>
		/// Default Count UOM(field from Inventory Location details screen)
		/// </summary>
		[StringLength(2)]
		public string DefaultCountUOM { get; set; }

		/// <summary>
		/// Default Count Conversion Factor
		/// </summary>
		public int? DefaultCountConversionFactor { get; set; }

		/// <summary>
		/// Inventory Location Cost
		/// </summary>
		public decimal? Cost { get; set; }

		/// <summary>
		/// Indicates whether Inventory Location is billable or not
		/// </summary>
		public bool? IsBillable { get; set; }

		/// <summary>
		/// Indicates whether Inventory Location is taxable or not
		/// </summary>
		public bool? IsTaxable { get; set; }

		/// <summary>
		/// Item type
		/// </summary>
		public byte? ItemType { get; set; }

		/// <summary>
		/// Item type text represenation
		/// </summary>
		public string ItemTypeText { get; set; }

		/// <summary>
		/// Price markup value
		/// </summary>
		public decimal? PriceMarkup { get; set; }

		/// <summary>
		/// Price markup Type
		/// </summary>
		public byte? PriceMarkupType { get; set; }

		/// <summary>
		/// Type of price markup: %, $, etc.
		/// </summary>
		public string PriceMarkupTypeText { get; set; }

		/// <summary>
		/// Whether this Inventory Location item specified by 'InventoryId' is able to be added to a purchase order.
		/// </summary>
		public bool? DisablePurchasing { get; set; }

		/// <summary>
		/// The minimum quantity that we want to keep in stock for the Inventory item specified by 'InventoryId'.
		/// </summary>
		public int? MinQuantity { get; set; }

		public int? OnRequisition { get; set; }

		/// <summary>
		/// The maximum quantity that we want to keep in stock for the Inventory item specified by 'InventoryId'.
		/// </summary>
		public int? MaxQuantity { get; set; }

		/// <summary>
		/// Safety Stock Quantity. Used for sending safety stock alerts.
		/// </summary>
		public int? SafetyStock { get; set; }

		/// <summary>
		/// Represents the shelf location of the Inventory item specified by 'InventoryId'.
		/// </summary>
		[StringLength(50)]
		public string BinShelf { get; set; }

		/// <summary>
		/// Asset Ledger Number
		/// </summary>
		[StringLength(50)]
		public string AssetLedgerNo { get; set; }

		/// <summary>
		/// Expense Ledger Number
		/// </summary>
		[StringLength(50)]
		public string ExpenseLedgerNo { get; set; }

		/// <summary>
		/// Indicates whether this Inventory Location item is to be synced with an external system.
		/// </summary>
		public bool? SyncFlag { get; set; }

		/// <summary>
		/// Date the cost was last updated.
		/// </summary>
		public DateTimeOffset? CostLastUpdated { get; set; }

		/// <summary>
		/// User who last updated the cost.
		/// </summary>
		public Guid? CostLastUpdatedBy { get; set; }

		/// <summary>
		/// Date this record was first inserted.
		/// </summary>
		public DateTimeOffset? DateAdded { get; set; }

		/// <summary>
		/// Indicates which user inserted this record.
		/// </summary>
		public Guid? AddedBy { get; set; }

		/// <summary>
		/// Date this record was last updated.
		/// </summary>
		public DateTimeOffset? LastUpdated { get; set; }

		/// <summary>
		/// Indicates which user last updated this record.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Value representing status of this Inventory Location item. 
		/// If this Inventory Location item is active value is True, 
		/// otherwise - False.
		/// </summary>
		public bool? ActiveStatus { get; set; }

		/// <summary>
		/// Location Synchronization Date value
		/// </summary>
		public DateTimeOffset? LocationSynchronizationDate { get; set; }

		/// <summary>
		/// Gets or sets the cost synchronization date.
		/// (Just a copy of LocationSynchronizationDate for OData)
		/// </summary>
		public DateTimeOffset? CostSynchronizationDate
		{
			get
			{
				return LocationSynchronizationDate;
			}
			set
			{
				LocationSynchronizationDate = CostSynchronizationDate;
			}
		}

		/// <summary>
		/// Default Purchase UOM value
		/// </summary>
		public string DefaultPurchaseUOM { get; set; }

		/// <summary>
		/// Validation method
		/// </summary>
		public byte? ValuationMethod { get; set; }

		/// <summary>
		/// Validation method text representation
		/// </summary>
		public string ValuationMethodText { get; set; }

		/// <summary>
		/// Pending Orders Count
		/// </summary>
		public int? PendingOrders { get; set; }

		/// <summary>
		/// Submitted Orders Count
		/// </summary>
		public int? SubmittedOrders { get; set; }

		/// <summary>
		/// Quantity on hand value
		/// </summary>
		public int? QuantityOnHand { get; set; }

		/// <summary>
		/// Last Updated By Name
		/// </summary>
		public string LastUpdatedByName { get; set; }

		/// <summary>
		/// Added By Name
		/// </summary>
		public string AddedByName { get; set; }

		/// <summary>
		/// Cost Last Updated By Name
		/// </summary>
		public string CostLastUpdatedByName { get; set; }

		/// <summary>
		/// Holds Cross Reference No value 
		/// </summary>
		[StringLength(50)]
		public string CrossReferenceNo { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [inventory active status].
		/// </summary>
		public bool InventoryActiveStatus { get; set; }
	}
}
