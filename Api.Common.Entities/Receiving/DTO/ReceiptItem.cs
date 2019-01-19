using System;

namespace Api.Common.Entities.Receiving.DTO
{
	/// <summary>
	/// Class that describes Receipt History Item 
	/// </summary>
	public class ReceiptItem
	{
		/// <summary>
		/// Get or set the po receipt Id value.
		/// </summary>
		public Guid? ReceiptId { get; set; }

		/// <summary>
		/// Get or set the purchase order Id value.
		/// </summary>
		public Guid? PurchaseOrderId { get; set; }

		/// <summary>
		/// Get or set the purshase order item Id value.
		/// </summary>
		public Guid? PurchaseOrderItemId { get; set; }

		/// <summary>
		/// Get or set the purchase order no.
		/// </summary>
		public string PurchaseOrderNo { get; set; }

		/// <summary>
		/// Get or set the sequence no.
		/// </summary>
		public int? SequenceNo { get; set; }

		/// <summary>
		/// Get or set the po receipt item Id value.
		/// </summary>
		public Guid ReceiptItemId { get; set; }

		/// <summary>
		/// Get or set the line item no.
		/// </summary>
		public int? LineItemNo { get; set; }

		/// <summary>
		/// Get or set the inventory no.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Get or set the inventory description.
		/// </summary>
		public string InventoryDescription { get; set; }

		/// <summary>
		/// Get or set the vendor item no.
		/// </summary>
		public string VendorItemNo { get; set; }

		/// <summary>
		/// Get or set the manufacturer Id value.
		/// </summary>
		public Guid? ManufacturerId { get; set; }

		/// <summary>
		/// Get or set the manufacturer no.
		/// </summary>
		public string ManufacturerNo { get; set; }

		/// <summary>
		/// Get or set the name of the manufacturer.
		/// </summary>
		public string ManufacturerName { get; set; }

		/// <summary>
		/// Get or set the manufacturer item no.
		/// </summary>
		public string ManufacturerItemNo { get; set; }

		/// <summary>
		/// Get or set the lot no.
		/// </summary>
		public string LotNo { get; set; }

		/// <summary>
		/// Get or set the serial no.
		/// </summary>
		public string SerialNo { get; set; }

		/// <summary>
		/// Get or set the expiration date.
		/// </summary>
		public DateTime? ExpirationDate { get; set; }

		/// <summary>
		/// Get or set the purchase order item notes.
		/// </summary>
		public string PurchaseOrderItemNotes { get; set; }

		/// <summary>
		/// Get or set the department gl code.
		/// </summary>
		public string DepartmentGLCode { get; set; }

		/// <summary>
		/// Get or set the gl code.
		/// </summary>
		public string GlCode { get; set; }

		/// <summary>
		/// Get or set the classification.
		/// </summary>
		public string Classification { get; set; }

		/// <summary>
		/// Get or set the classification2.
		/// </summary>
		public string Classification2 { get; set; }

		/// <summary>
		/// Get or set the cost.
		/// </summary>
		public decimal? Cost { get; set; }

		/// <summary>
		/// Get or set the ordered quantity.
		/// </summary>
		public int? OrderedQuantity { get; set; }

		/// <summary>
		/// Get or set the ordered uom.
		/// </summary>
		public string OrderedUOM { get; set; }

		/// <summary>
		/// Get or set the ordered conversion factor.
		/// </summary>
		public int? OrderedConversionFactor { get; set; }

		/// <summary>
		/// Get or set the received quantity.
		/// </summary>
		public int? ReceivedQuantity { get; set; }

		/// <summary>
		/// Get or set the received uom.
		/// </summary>
		public string ReceivedUOM { get; set; }

		/// <summary>
		/// Get or set the received conversion factor.
		/// </summary>
		public int? ReceivedConversionFactor { get; set; }

		/// <summary>
		/// Get or set the date added.
		/// </summary>
		public DateTime? DateAdded { get; set; }

		/// <summary>
		/// Get or set the added by.
		/// </summary>
		public Guid? AddedBy { get; set; }

		/// <summary>
		/// Get or set the name of the added by user.
		/// </summary>
		public string AddedByUserName { get; set; }

		/// <summary>
		/// Get or set the last updated.
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Get or set the last updated by.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get or set the last name of the updated by user.
		/// </summary>
		public string LastUpdatedByUserName { get; set; }
	}
}
