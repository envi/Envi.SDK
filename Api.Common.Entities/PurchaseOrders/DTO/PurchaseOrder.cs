using System;
using System.Collections.Generic;
using PurchaseOrderItemDTO = Api.Common.Entities.PurchaseOrders.DTO.PurchaseOrderItem;


namespace Api.Common.Entities.PurchaseOrders.DTO
{

	/// <summary>
	/// Class PurchaseOrder.
	/// </summary>
	public class PurchaseOrder
	{
		/// <summary>
		/// Gets or sets the purchase order identifier.
		/// </summary>
		public Guid? PurchaseOrderId { get; set; }

		/// <summary>
		/// Gets or sets the purchase order no.
		/// </summary>
		public string PurchaseOrderNo { get; set; }

		/// <summary>
		/// Gets or sets the sequence no.
		/// </summary>
		public int? SequenceNo { get; set; }

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
		/// Gets or sets the location identifier.
		/// </summary>
		public Guid? LocationId { get; set; }

		/// <summary>
		/// Gets or sets the location no.
		/// </summary>
		public string LocationNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the location.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Gets or sets the po type identifier.
		/// </summary>
		public byte? POTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type of the po.
		/// </summary>
		public string POType { get; set; }

		/// <summary>
		/// Gets or sets the buyer identifier.
		/// </summary>
		public Guid? BuyerId { get; set; }

		/// <summary>
		/// Gets or sets the name of the buyer user.
		/// </summary>
		public string BuyerUserName { get; set; }

		/// <summary>
		/// Gets or sets the expected delivery date.
		/// </summary>
		public DateTime? ExpectedDeliveryDate { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		public string Reference { get; set; }

		/// <summary>
		/// Gets or sets the order date.
		/// </summary>
		public DateTime? OrderDate { get; set; }

		/// <summary>
		/// Gets or sets the sent by.
		/// </summary>
		public Guid? SentBy { get; set; }

		/// <summary>
		/// Gets or sets the name of the sent by user.
		/// </summary>
		public string SentByUserName { get; set; }

		/// <summary>
		/// Gets or sets the return type identifier.
		/// </summary>
		public byte? ReturnTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type of the return.
		/// </summary>
		public string ReturnType { get; set; }

		/// <summary>
		/// Gets or sets the return date.
		/// </summary>
		public DateTime? ReturnDate { get; set; }

		/// <summary>
		/// Gets or sets the returned by.
		/// </summary>
		public Guid? ReturnedBy { get; set; }

		/// <summary>
		/// Gets or sets the name of the returned by user.
		/// </summary>
		public string ReturnedByUserName { get; set; }

		/// <summary>
		/// Gets or sets the po status identifier.
		/// </summary>
		public byte? POStatusId { get; set; }

		/// <summary>
		/// Gets or sets the po status.
		/// </summary>
		public string POStatus { get; set; }

		/// <summary>
		/// Gets or sets the invoice status identifier.
		/// </summary>
		public byte? InvoiceStatusId { get; set; }

		/// <summary>
		/// Gets or sets the invoice status.
		/// </summary>
		public string InvoiceStatus { get; set; }

		/// <summary>
		/// Gets or sets the po source identifier.
		/// </summary>
		public byte? POSourceId { get; set; }

		/// <summary>
		/// Gets or sets the po source.
		/// </summary>
		public string POSource { get; set; }

		/// <summary>
		/// Gets or sets the send method identifier.
		/// </summary>
		public byte? SendMethodId { get; set; }

		/// <summary>
		/// Gets or sets the send method.
		/// </summary>
		public string SendMethod { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether po confirmation flag.
		/// </summary>
		public bool? POConfirmationFlag { get; set; }

		/// <summary>
		/// Gets or sets the po confirmation date.
		/// </summary>
		public DateTime? POConfirmationDate { get; set; }

		/// <summary>
		/// Gets or sets the name of the po confirmation.
		/// </summary>
		public string POConfirmationName { get; set; }

		/// <summary>
		/// Gets or sets the po confirmation number.
		/// </summary>
		public string POConfirmationNumber { get; set; }

		/// <summary>
		/// Gets or sets the cer identifier.
		/// </summary>
		public Guid? CerId { get; set; }

		/// <summary>
		/// Gets or sets the cer no.
		/// </summary>
		public string CerNo { get; set; }

		/// <summary>
		/// Gets or sets the cer no description.
		/// </summary>
		public string CerNoDescription { get; set; }

		/// <summary>
		/// Gets or sets the payment terms.
		/// </summary>
		public string PaymentTerms { get; set; }

		/// <summary>
		/// Gets or sets the payment method.
		/// </summary>
		public string PaymentMethod { get; set; }

		/// <summary>
		/// Gets or sets the bill to account no.
		/// </summary>
		public string BillToAccountNo { get; set; }

		/// <summary>
		/// Gets or sets the ship to account no.
		/// </summary>
		public string ShipToAccountNo { get; set; }

		/// <summary>
		/// Gets or sets the fob.
		/// </summary>
		public string FOB { get; set; }

		/// <summary>
		/// Gets or sets the ship method.
		/// </summary>
		public string ShipMethod { get; set; }

		/// <summary>
		/// Gets or sets the ship via.
		/// </summary>
		public string ShipVia { get; set; }

		/// <summary>
		/// Gets or sets the name of the shipping.
		/// </summary>
		public string ShippingName { get; set; }

		/// <summary>
		/// Gets or sets the shipping address1.
		/// </summary>
		public string ShippingAddress1 { get; set; }

		/// <summary>
		/// Gets or sets the shipping address2.
		/// </summary>
		public string ShippingAddress2 { get; set; }

		/// <summary>
		/// Gets or sets the shipping city.
		/// </summary>
		public string ShippingCity { get; set; }

		/// <summary>
		/// Gets or sets the state of the shipping.
		/// </summary>
		public string ShippingState { get; set; }

		/// <summary>
		/// Gets or sets the shipping zip.
		/// </summary>
		public string ShippingZip { get; set; }

		/// <summary>
		/// Gets or sets the name of the shipping contact.
		/// </summary>
		public string ShippingContactName { get; set; }

		/// <summary>
		/// Gets or sets the shipping contact phone.
		/// </summary>
		public string ShippingContactPhone { get; set; }

		/// <summary>
		/// Gets or sets the shipping contact ext.
		/// </summary>
		public string ShippingContactExt { get; set; }

		/// <summary>
		/// Gets or sets the shipping contact email.
		/// </summary>
		public string ShippingContactEmail { get; set; }

		/// <summary>
		/// Gets or sets the shipping contact fax.
		/// </summary>
		public string ShippingContactFax { get; set; }

		/// <summary>
		/// Gets or sets the name of the billing.
		/// </summary>
		public string BillingName { get; set; }

		/// <summary>
		/// Gets or sets the billing address1.
		/// </summary>
		public string BillingAddress1 { get; set; }

		/// <summary>
		/// Gets or sets the billing address2.
		/// </summary>
		public string BillingAddress2 { get; set; }

		/// <summary>
		/// Gets or sets the billing city.
		/// </summary>
		public string BillingCity { get; set; }

		/// <summary>
		/// Gets or sets the state of the billing.
		/// </summary>
		public string BillingState { get; set; }

		/// <summary>
		/// Gets or sets the billing zip.
		/// </summary>
		public string BillingZip { get; set; }

		/// <summary>
		/// Gets or sets the name of the billing contact.
		/// </summary>
		public string BillingContactName { get; set; }

		/// <summary>
		/// Gets or sets the billing contact phone.
		/// </summary>
		public string BillingContactPhone { get; set; }

		/// <summary>
		/// Gets or sets the billing contact ext.
		/// </summary>
		public string BillingContactExt { get; set; }

		/// <summary>
		/// Gets or sets the billing contact email.
		/// </summary>
		public string BillingContactEmail { get; set; }

		/// <summary>
		/// Gets or sets the billing contact fax.
		/// </summary>
		public string BillingContactFax { get; set; }

		/// <summary>
		/// Gets or sets the vendor identifier.
		/// </summary>
		public Guid? VendorId { get; set; }

		/// <summary>
		/// Gets or sets the vendor no.
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the vendor.
		/// </summary>
		public string VendorName { get; set; }

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
		/// Gets or sets the discount.
		/// </summary>
		public decimal? Discount { get; set; }

		/// <summary>
		/// Gets or sets the discount type identifier.
		/// </summary>
		public byte? DiscountTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type of the discount.
		/// </summary>
		public string DiscountType { get; set; }

		/// <summary>
		/// Gets or sets the sales tax.
		/// </summary>
		public decimal? SalesTax { get; set; }

		/// <summary>
		/// Gets or sets the sales tax identifier.
		/// </summary>
		public byte? SalesTaxId { get; set; }

		/// <summary>
		/// Gets or sets the type of the sales tax.
		/// </summary>
		public string SalesTaxType { get; set; }

		/// <summary>
		/// Gets or sets the shipping.
		/// </summary>
		public decimal? Shipping { get; set; }

		/// <summary>
		/// Gets or sets the shipping type identifier.
		/// </summary>
		public byte? ShippingTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type of the shipping.
		/// </summary>
		public string ShippingType { get; set; }

		/// <summary>
		/// Gets or sets the purchase order items.
		/// </summary>
		public List<PurchaseOrderItemDTO> PurchaseOrderItems { get; set; }
	}
}
