using System;

namespace Api.Common.Entities.PurchaseOrders.DTO
{

	/// <summary>
	/// Class PurchaseOrderItem.
	/// </summary>
	public class PurchaseOrderItem
	{
		/// <summary>
		/// Gets or sets the purchase order item identifier.
		/// </summary>
		public Guid? PurchaseOrderItemId { get; set; }

		/// <summary>
		/// Gets or sets the purchase order no.
		/// </summary>
		public string PurchaseOrderNo { get; set; }

		/// <summary>
		/// Gets or sets the sequence no.
		/// </summary>
		public int? SequenceNo { get; set; }

		/// <summary>
		/// Gets or sets the purchase order identifier.
		/// </summary>
		public Guid? PurchaseOrderId { get; set; }

		/// <summary>
		/// Gets or sets the facility identifier.
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Gets or sets the facility no.
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the facility.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Gets or sets the line item no.
		/// </summary>
		public int? LineItemNo { get; set; }

		/// <summary>
		/// Gets or sets the location no.
		/// </summary>
		public string LocationNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the location.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Gets or sets the inventory location identifier.
		/// </summary>
		public Guid? InventoryLocationId { get; set; }

		/// <summary>
		/// Gets or sets the inventory vendor identifier.
		/// </summary>
		public Guid? InventoryVendorId { get; set; }

		/// <summary>
		/// Gets or sets the vendor no.
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the vendor.
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Gets or sets the vendor priority.
		/// </summary>
		public int? VendorPriority { get; set; }

		/// <summary>
		/// Gets or sets the inventory no.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Gets or sets the classification identifier.
		/// </summary>
		public Guid? ClassificationId { get; set; }

		/// <summary>
		/// Gets or sets the name of the classification.
		/// </summary>
		public string ClassificationName { get; set; }

		/// <summary>
		/// Gets or sets the classification2 identifier.
		/// </summary>
		public Guid? Classification2Id { get; set; }

		/// <summary>
		/// Gets or sets the name of the classification2.
		/// </summary>
		public string Classification2Name { get; set; }

		/// <summary>
		/// Gets or sets the inventory description.
		/// </summary>
		public string InventoryDescription { get; set; }

		/// <summary>
		/// Gets or sets the vendor item no.
		/// </summary>
		public string VendorItemNo { get; set; }

		/// <summary>
		/// Gets or sets the manufacturer identifier.
		/// </summary>
		public Guid? ManufacturerId { get; set; }

		/// <summary>
		/// Gets or sets the manufacturer no.
		/// </summary>
		public string ManufacturerNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the manufacturer.
		/// </summary>
		public string ManufacturerName { get; set; }

		/// <summary>
		/// Gets or sets the manufacturer item no.
		/// </summary>
		public string ManufacturerItemNo { get; set; }

		/// <summary>
		/// Gets or sets the order quantity.
		/// </summary>
		public int? OrderQuantity { get; set; }

		/// <summary>
		/// Gets or sets the order uom.
		/// </summary>
		public string OrderUOM { get; set; }

		/// <summary>
		/// Gets or sets the order conversion factor.
		/// </summary>
		public int? OrderConversionFactor { get; set; }

		/// <summary>
		/// Gets or sets the stock uom.
		/// </summary>
		public string StockUOM { get; set; }

		/// <summary>
		/// Gets or sets the unit cost.
		/// </summary>
		public decimal? UnitCost { get; set; }

		/// <summary>
		/// Gets or sets the department gl code.
		/// </summary>
		public string DepartmentGLCode { get; set; }

		/// <summary>
		/// Gets or sets the gl code.
		/// </summary>
		public string GLCode { get; set; }

		/// <summary>
		/// Gets or sets the line item type identifier.
		/// </summary>
		public byte? LineItemTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type of the item.
		/// </summary>
		public string ItemType { get; set; }

		/// <summary>
		/// Gets or sets the line item notes.
		/// </summary>
		public string LineItemNotes { get; set; }

		/// <summary>
		/// Gets or sets the contract no.
		/// </summary>
		public string ContractNo { get; set; }

		/// <summary>
		/// Gets or sets the contract exp date.
		/// </summary>
		public DateTime? ContractExpDate { get; set; }

		/// <summary>
		/// Gets or sets the last updated.
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Gets or sets the last updated by.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Gets or sets the last name of the updated by user.
		/// </summary>
		public string LastUpdatedByUserName { get; set; }

		/// <summary>
		/// Gets or sets the date created.
		/// </summary>
		public DateTime? DateCreated { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		public Guid? CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the name of the created by user.
		/// </summary>
		public string CreatedByUserName { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is taxable.
		/// </summary>
		public bool? IsTaxable { get; set; }

		/// <summary>
		/// Gets or sets the return po item identifier.
		/// </summary>
		public Guid? ReturnPOItemId { get; set; }

		/// <summary>
		/// Gets or sets the internal notes.
		/// </summary>
		public string InternalNotes { get; set; }

		/// <summary>
		/// Gets or sets the lot no.
		/// </summary>
		public string LotNo { get; set; }

		/// <summary>
		/// Gets or sets the serial no.
		/// </summary>
		public string SerialNo { get; set; }

		/// <summary>
		/// Gets or sets the expiration date.
		/// </summary>
		public DateTime? ExpirationDate { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether active status.
		/// </summary>
		public bool? ActiveStatus { get; set; }

		/// <summary>
		/// Gets or sets the active status last updated.
		/// </summary>
		public DateTime? ActiveStatusLastUpdated { get; set; }

		/// <summary>
		/// Gets or sets the active status last updated by.
		/// </summary>
		public Guid? ActiveStatusLastUpdatedBy { get; set; }

		/// <summary>
		/// Gets or sets the name of the active status last updated by user.
		/// </summary>
		public string ActiveStatusLastUpdatedByUserName { get; set; }

		/// <summary>
		/// Gets or sets the supplier part auxiliary identifier.
		/// </summary>
		public string SupplierPartAuxiliaryID { get; set; }

		/// <summary>
		/// Gets or sets the submitted unit cost.
		/// </summary>
		public decimal? SubmittedUnitCost { get; set; }

		/// <summary>
		/// Gets or sets the department identifier.
		/// </summary>
		public Guid? DepartmentId { get; set; }

		/// <summary>
		/// Gets or sets the department no.
		/// </summary>
		public string DepartmentNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the department.
		/// </summary>
		public string DepartmentName { get; set; }
	}
}
