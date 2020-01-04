using System;

namespace Api.Common.Entities.PurchaseOrders.DTO
{
	/// <summary>
	/// Purchase Order Item DTO (OData)
	/// </summary>
	public class PurchaseOrderItem
	{
		/// <summary>Gets or sets the purchase order item identifier.</summary>
		/// <value>The purchase order item identifier.</value>
		public Guid? PurchaseOrderItemId { get; set; }


		/// <summary>Gets or sets the purchase order no.</summary>
		/// <value>The purchase order no.</value>
		public string PurchaseOrderNo { get; set; }


		/// <summary>Gets or sets the sequence no.</summary>
		/// <value>The sequence no.</value>
		public int? SequenceNo { get; set; }


		/// <summary>Gets or sets the purchase order identifier.</summary>
		/// <value>The purchase order identifier.</value>
		public Guid? PurchaseOrderId { get; set; }

		/// <summary>Gets or sets the facility identifier.</summary>
		/// <value>The facility identifier.</value>
		public Guid? FacilityId { get; set; }

		/// <summary>Gets or sets the facility no.</summary>
		/// <value>The facility no.</value>
		public string FacilityNo { get; set; }

		/// <summary>Gets or sets the name of the facility.</summary>
		/// <value>The name of the facility.</value>
		public string FacilityName { get; set; }

		/// <summary>Gets or sets the line item no.</summary>
		/// <value>The line item no.</value>
		public int? LineItemNo { get; set; }

		/// <summary>Gets or sets the location no.</summary>
		/// <value>The location no.</value>
		public string LocationNo { get; set; }

		/// <summary>Gets or sets the name of the location.</summary>
		/// <value>The name of the location.</value>
		public string LocationName { get; set; }

		/// <summary>Gets or sets the inventory location identifier.</summary>
		/// <value>The inventory location identifier.</value>
		public Guid? InventoryLocationId { get; set; }

		/// <summary>Gets or sets the inventory vendor identifier.</summary>
		/// <value>The inventory vendor identifier.</value>
		public Guid? InventoryVendorId { get; set; }

		/// <summary>Gets or sets the vendor no.</summary>
		/// <value>The vendor no.</value>
		public string VendorNo { get; set; }

		/// <summary>Gets or sets the name of the vendor.</summary>
		/// <value>The name of the vendor.</value>
		public string VendorName { get; set; }

		/// <summary>Gets or sets the vendor priority.</summary>
		/// <value>The vendor priority.</value>
		public int? VendorPriority { get; set; }

		/// <summary>Gets or sets the inventory no.</summary>
		/// <value>The inventory no.</value>
		public string InventoryNo { get; set; }

		/// <summary>Gets or sets the classification identifier.</summary>
		/// <value>The classification identifier.</value>
		public Guid? ClassificationId { get; set; }

		/// <summary>Gets or sets the name of the classification.</summary>
		/// <value>The name of the classification.</value>
		public string ClassificationName { get; set; }

		/// <summary>Gets or sets the classification2 identifier.</summary>
		/// <value>The classification2 identifier.</value>
		public Guid? Classification2Id { get; set; }

		/// <summary>Gets or sets the name of the classification2.</summary>
		/// <value>The name of the classification2.</value>
		public string Classification2Name { get; set; }

		/// <summary>Gets or sets the inventory description.</summary>
		/// <value>The inventory description.</value>
		public string InventoryDescription { get; set; }

		/// <summary>Gets or sets the vendor item no.</summary>
		/// <value>The vendor item no.</value>
		public string VendorItemNo { get; set; }

		/// <summary>Gets or sets the manufacturer identifier.</summary>
		/// <value>The manufacturer identifier.</value>
		public Guid? ManufacturerId { get; set; }

		/// <summary>Gets or sets the manufacturer no.</summary>
		/// <value>The manufacturer no.</value>
		public string ManufacturerNo { get; set; }

		/// <summary>Gets or sets the name of the manufacturer.</summary>
		/// <value>The name of the manufacturer.</value>
		public string ManufacturerName { get; set; }

		/// <summary>Gets or sets the manufacturer item no.</summary>
		/// <value>The manufacturer item no.</value>
		public string ManufacturerItemNo { get; set; }

		/// <summary>Gets or sets the order quantity.</summary>
		/// <value>The order quantity.</value>
		public int? OrderQuantity { get; set; }

		/// <summary>Gets or sets the order uom.</summary>
		/// <value>The order uom.</value>
		public string OrderUOM { get; set; }

		/// <summary>Gets or sets the order conversion factor.</summary>
		/// <value>The order conversion factor.</value>
		public int? OrderConversionFactor { get; set; }

		/// <summary>Gets or sets the stock uom.</summary>
		/// <value>The stock uom.</value>
		public string StockUOM { get; set; }

		/// <summary>Gets or sets the unit cost.</summary>
		/// <value>The unit cost.</value>
		public decimal? UnitCost { get; set; }

		/// <summary>Gets or sets the department gl code.</summary>
		/// <value>The department gl code.</value>
		public string DepartmentGLCode { get; set; }

		/// <summary>Gets or sets the gl code.</summary>
		/// <value>The gl code.</value>
		public string GLCode { get; set; }

		/// <summary>Gets or sets the line item type identifier.</summary>
		/// <value>The line item type identifier.</value>
		public byte? LineItemTypeId { get; set; }

		/// <summary>Gets or sets the type of the item.</summary>
		/// <value>The type of the item.</value>
		public string ItemType { get; set; }

		/// <summary>Gets or sets the line item notes.</summary>
		/// <value>The line item notes.</value>
		public string LineItemNotes { get; set; }

		/// <summary>Gets or sets the contract no.</summary>
		/// <value>The contract no.</value>
		public string ContractNo { get; set; }

		public DateTime? ContractExpDate { get; set; }

		public DateTime? LastUpdated { get; set; }

		public Guid? LastUpdatedBy { get; set; }

		public string LastUpdatedByUserName { get; set; }

		/// <summary>Gets or sets the date created.</summary>
		/// <value>The date created.</value>
		public DateTime? DateCreated { get; set; }

		/// <summary>Gets or sets the created by.</summary>
		/// <value>The created by.</value>
		public Guid? CreatedBy { get; set; }

		/// <summary>Gets or sets the name of the created by user.</summary>
		/// <value>The name of the created by user.</value>
		public string CreatedByUserName { get; set; }

		/// <summary>Gets or sets the is taxable.</summary>
		/// <value>The is taxable.</value>
		public bool? IsTaxable { get; set; }

		/// <summary>Gets or sets the return po item identifier.</summary>
		/// <value>The return po item identifier.</value>
		public Guid? ReturnPOItemId { get; set; }

		/// <summary>Gets or sets the internal notes.</summary>
		/// <value>The internal notes.</value>
		public string InternalNotes { get; set; }

		/// <summary>Gets or sets the lot no.</summary>
		/// <value>The lot no.</value>
		public string LotNo { get; set; }

		/// <summary>Gets or sets the serial no.</summary>
		/// <value>The serial no.</value>
		public string SerialNo { get; set; }

		/// <summary>Gets or sets the expiration date.</summary>
		/// <value>The expiration date.</value>
		public DateTime? ExpirationDate { get; set; }

		/// <summary>Gets or sets the active status.</summary>
		/// <value>The active status.</value>
		public bool? ActiveStatus { get; set; }

		/// <summary>Gets or sets the active status last updated.</summary>
		/// <value>The active status last updated.</value>
		public DateTime? ActiveStatusLastUpdated { get; set; }

		/// <summary>Gets or sets the active status last updated by.</summary>
		/// <value>The active status last updated by.</value>
		public Guid? ActiveStatusLastUpdatedBy { get; set; }

		/// <summary>Gets or sets the name of the active status last updated by user.</summary>
		/// <value>The name of the active status last updated by user.</value>
		public string ActiveStatusLastUpdatedByUserName { get; set; }

		/// <summary>Gets or sets the supplier part auxiliary identifier.</summary>
		/// <value>The supplier part auxiliary identifier.</value>
		public string SupplierPartAuxiliaryID { get; set; }

		/// <summary>Gets or sets the submitted unit cost.</summary>
		/// <value>The submitted unit cost.</value>
		public decimal? SubmittedUnitCost { get; set; }

		/// <summary>Gets or sets the department identifier.</summary>
		/// <value>The department identifier.</value>
		public Guid? DepartmentId { get; set; }

		/// <summary>Gets or sets the department no.</summary>
		/// <value>The department no.</value>
		public string DepartmentNo { get; set; }

		/// <summary>Gets or sets the name of the department.</summary>
		/// <value>The name of the department.</value>
		public string DepartmentName { get; set; }
	}
}
