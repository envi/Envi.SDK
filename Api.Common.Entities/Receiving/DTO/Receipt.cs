using System;

namespace Api.Common.Entities.Receiving.DTO
{
	/// <summary>
	/// Class that describes Receipt History Item 
	/// </summary>
	public class Receipt
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
		/// Get or set the purchase order no.
		/// </summary>
		public string PurchaseOrderNo { get; set; }

		/// <summary>
		/// Get or set the sequence no.
		/// </summary>
		public int? SequenceNo { get; set; }

		/// <summary>
		/// Get or set the purchase order reference.
		/// </summary>
		public string PurchaseOrderReference { get; set; }

		/// <summary>
		/// Get or set the vendor Id value.
		/// </summary>
		public Guid? VendorId { get; set; }

		/// <summary>
		/// Get or set the vendor no.
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Get or set the name of the vendor.
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Get or set the lead time.
		/// </summary>
		public int? LeadTime { get; set; }

		/// <summary>
		/// Get or set the facility Id value.
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Get or set the facility no.
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Get or set the name of the facility.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Get or set the location Id value.
		/// </summary>
		public Guid? LocationId { get; set; }

		/// <summary>
		/// Get or set the location no.
		/// </summary>
		public string LocationNo { get; set; }

		/// <summary>
		/// Get or set the name of the location.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Get or set the expected delivery date.
		/// </summary>
		public DateTimeOffset? ExpectedDeliveryDate { get; set; }

		/// <summary>
		/// Get or set the po status Id value.
		/// </summary>
		public byte? PurchaseOrderStatusId { get; set; }

		/// <summary>
		/// Get or set the po status.
		/// </summary>
		public string PurchaseOrderStatus { get; set; }

		/// <summary>
		/// Gets or sets the buyer identifier.
		/// </summary>
		public Guid? BuyerId { get; set; }

		/// <summary>
		/// Gets or sets first and last name of the buyer user.
		/// </summary>
		public string BuyerName { get; set; }

		/// <summary>
		/// Gets or sets first and last name of the buyer user.
		/// </summary>
		public string BuyerUserName { get; set; }

		/// <summary>
		/// Get or set the po confirmation flag.
		/// </summary>
		public bool? POConfirmationFlag { get; set; }

		/// <summary>
		/// Get or set the po confirmation date.
		/// </summary>
		public DateTimeOffset? POConfirmationDate { get; set; }

		/// <summary>
		/// Get or set the name of the po confirmation.
		/// </summary>
		public string POConfirmationName { get; set; }

		/// <summary>
		/// Get or set the po confirmation number.
		/// </summary>
		public string POConfirmationNumber { get; set; }

		/// <summary>
		/// Get or set the order date.
		/// </summary>
		public DateTimeOffset? OrderDate { get; set; }

		/// <summary>
		/// Get or set the order by.
		/// </summary>
		public Guid? OrderBy { get; set; }

		/// <summary>
		/// Get or set the order by.
		/// </summary>
		public string OrderByUserName { get; set; }

		/// <summary>
		/// Get or set first and last name of the order by user.
		/// </summary>
		public string OrderByName { get; set; }

		/// <summary>
		/// Get or set the packing slip number.
		/// </summary>
		public string PackingSlipNumber { get; set; }

		/// <summary>
		/// Get or set the date added.
		/// </summary>
		public DateTimeOffset? DateAdded { get; set; }

		/// <summary>
		/// Get or set the added by.
		/// </summary>
		public Guid? AddedBy { get; set; }

		/// <summary>
		/// Get or set first and last name of the added by user.
		/// </summary>
		public string AddedByName { get; set; }

		/// <summary>
		/// Get or set first and last name of the added by user.
		/// </summary>
		public string AddedByUserName { get; set; }

		/// <summary>
		/// Get or set the date submitted.
		/// </summary>
		public DateTimeOffset? DateSubmitted { get; set; }

		/// <summary>
		/// Get or set the receipt date.
		/// </summary>
		public DateTimeOffset? ReceiptDate { get; set; }

		/// <summary>
		/// Get or set the received by.
		/// </summary>
		public Guid? ReceivedBy { get; set; }

		/// <summary>
		/// Get or set first and last name of the received by user.
		/// </summary>
		public string ReceivedByName { get; set; }

		/// <summary>
		/// Get or set first and last name of the received by user.
		/// </summary>
		public string ReceivedByUserName { get; set; }

		/// <summary>
		/// Get or set the po receipt status Id value.
		/// </summary>
		public byte? ReceiptStatusId { get; set; }

		/// <summary>
		/// Get or set the po receipt status.
		/// </summary>
		public string ReceiptStatus { get; set; }

		/// <summary>
		/// Get or set the last updated.
		/// </summary>
		public DateTimeOffset? LastUpdated { get; set; }

		/// <summary>
		/// Get or set the last updated by.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get or set the last updated by.
		/// </summary>
		public string LastUpdatedByUserName { get; set; }

		/// <summary>
		/// Get or set first and last name of the last updated by user.
		/// </summary>
		public string LastUpdatedByName { get; set; }

		/// <summary>
		/// Get or set the receipt fill status.
		/// </summary>
		public bool? ReceiptFillStatus { get; set; }

		/// <summary>
		/// Purchase Order receipt source id
		/// </summary>
		public byte ReceiptSourceId { get; set; }

		/// <summary>
		/// Purchase Order receipt source name
		/// </summary>
		public string ReceiptSource { get; set; }
	}
}
