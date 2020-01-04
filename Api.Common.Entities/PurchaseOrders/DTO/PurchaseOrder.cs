using System;
using System.Collections.Generic;

using PurchaseOrderItemDTO = Api.Common.Entities.PurchaseOrders.DTO.PurchaseOrderItem;


namespace Api.Common.Entities.PurchaseOrders.DTO
{
	/// <summary>
	/// Purchase Order DTO (OData)
	/// </summary>
	public class PurchaseOrder
	{

		/// <summary>Gets or sets the purchase order identifier.</summary>
		/// <value>The purchase order identifier.</value>
		public Guid? PurchaseOrderId { get; set; }

		/// <summary>Gets or sets the purchase order no.</summary>
		/// <value>The purchase order no.</value>
		public string PurchaseOrderNo { get; set; }

		/// <summary>Gets or sets the sequence no.</summary>
		/// <value>The sequence no.</value>
		public int? SequenceNo { get; set; }

		/// <summary>Gets or sets the facility identifier.</summary>
		/// <value>The facility identifier.</value>
		public Guid? FacilityId { get; set; }

		/// <summary>Gets or sets the facility no.</summary>
		/// <value>The facility no.</value>
		public string FacilityNo { get; set; }

		/// <summary>Gets or sets the name of the facility.</summary>
		/// <value>The name of the facility.</value>
		public string FacilityName { get; set; }

		/// <summary>Gets or sets the location identifier.</summary>
		/// <value>The location identifier.</value>
		public Guid? LocationId { get; set; }

		public string LocationNo { get; set; }

		/// <summary>Gets or sets the name of the location.</summary>
		/// <value>The name of the location.</value>
		public string LocationName { get; set; }

		/// <summary>Gets or sets the po type identifier.</summary>
		/// <value>The po type identifier.</value>
		public byte? POTypeId { get; set; }

		/// <summary>Gets or sets the type of the po.</summary>
		/// <value>The type of the po.</value>
		public string POType { get; set; }

		/// <summary>Gets or sets the buyer identifier.</summary>
		/// <value>The buyer identifier.</value>
		public Guid? BuyerId { get; set; }

		/// <summary>Gets or sets the name of the buyer user.</summary>
		/// <value>The name of the buyer user.</value>
		public string BuyerUserName { get; set; }

		/// <summary>Gets or sets the expected delivery date.</summary>
		/// <value>The expected delivery date.</value>
		public DateTime? ExpectedDeliveryDate { get; set; }

		/// <summary>Gets or sets the reference.</summary>
		/// <value>The reference.</value>
		public string Reference { get; set; }

		/// <summary>Gets or sets the order date.</summary>
		/// <value>The order date.</value>
		public DateTime? OrderDate { get; set; }

		/// <summary>Gets or sets the sent by.</summary>
		/// <value>The sent by.</value>
		public Guid? SentBy { get; set; }

		/// <summary>Gets or sets the name of the sent by user.</summary>
		/// <value>The name of the sent by user.</value>
		public string SentByUserName { get; set; }

		/// <summary>Gets or sets the return type identifier.</summary>
		/// <value>The return type identifier.</value>
		public byte? ReturnTypeId { get; set; }

		/// <summary>Gets or sets the type of the return.</summary>
		/// <value>The type of the return.</value>
		public string ReturnType { get; set; }

		/// <summary>Gets or sets the return date.</summary>
		/// <value>The return date.</value>
		public DateTime? ReturnDate { get; set; }

		/// <summary>Gets or sets the returned by.</summary>
		/// <value>The returned by.</value>
		public Guid? ReturnedBy { get; set; }

		/// <summary>Gets or sets the name of the returned by user.</summary>
		/// <value>The name of the returned by user.</value>
		public string ReturnedByUserName { get; set; }

		/// <summary>Gets or sets the po status identifier.</summary>
		/// <value>The po status identifier.</value>
		public byte? POStatusId { get; set; }

		/// <summary>Gets or sets the po status.</summary>
		/// <value>The po status.</value>
		public string POStatus { get; set; }

		/// <summary>Gets or sets the invoice status identifier.</summary>
		/// <value>The invoice status identifier.</value>
		public byte? InvoiceStatusId { get; set; }

		/// <summary>Gets or sets the invoice status.</summary>
		/// <value>The invoice status.</value>
		public string InvoiceStatus { get; set; }

		public byte? POSourceId { get; set; }

		/// <summary>Gets or sets the po source.</summary>
		/// <value>The po source.</value>
		public string POSource { get; set; }

		/// <summary>Gets or sets the send method identifier.</summary>
		/// <value>The send method identifier.</value>
		public byte? SendMethodId { get; set; }

		/// <summary>Gets or sets the send method.</summary>
		/// <value>The send method.</value>
		public string SendMethod { get; set; }

		/// <summary>Gets or sets the po confirmation flag.</summary>
		/// <value>The po confirmation flag.</value>
		public bool? POConfirmationFlag { get; set; }

		/// <summary>Gets or sets the po confirmation date.</summary>
		/// <value>The po confirmation date.</value>
		public DateTime? POConfirmationDate { get; set; }

		/// <summary>Gets or sets the name of the po confirmation.</summary>
		/// <value>The name of the po confirmation.</value>
		public string POConfirmationName { get; set; }

		/// <summary>Gets or sets the po confirmation number.</summary>
		/// <value>The po confirmation number.</value>
		public string POConfirmationNumber { get; set; }

		/// <summary>Gets or sets the cer identifier.</summary>
		/// <value>The cer identifier.</value>
		public Guid? CerId { get; set; }

		/// <summary>Gets or sets the cer no.</summary>
		/// <value>The cer no.</value>
		public string CerNo { get; set; }

		/// <summary>Gets or sets the cer no description.</summary>
		/// <value>The cer no description.</value>
		public string CerNoDescription { get; set; }

		/// <summary>Gets or sets the payment terms.</summary>
		/// <value>The payment terms.</value>
		public string PaymentTerms { get; set; }

		/// <summary>Gets or sets the payment method.</summary>
		/// <value>The payment method.</value>
		public string PaymentMethod { get; set; }

		/// <summary>Gets or sets the bill to account no.</summary>
		/// <value>The bill to account no.</value>
		public string BillToAccountNo { get; set; }

		/// <summary>Gets or sets the ship to account no.</summary>
		/// <value>The ship to account no.</value>
		public string ShipToAccountNo { get; set; }

		/// <summary>Gets or sets the fob.</summary>
		/// <value>The fob.</value>
		public string FOB { get; set; }

		/// <summary>Gets or sets the ship method.</summary>
		/// <value>The ship method.</value>
		public string ShipMethod { get; set; }

		/// <summary>Gets or sets the ship via.</summary>
		/// <value>The ship via.</value>
		public string ShipVia { get; set; }

		/// <summary>Gets or sets the name of the shipping.</summary>
		/// <value>The name of the shipping.</value>
		public string ShippingName { get; set; }

		/// <summary>Gets or sets the shipping address1.</summary>
		/// <value>The shipping address1.</value>
		public string ShippingAddress1 { get; set; }

		/// <summary>Gets or sets the shipping address2.</summary>
		/// <value>The shipping address2.</value>
		public string ShippingAddress2 { get; set; }

		/// <summary>Gets or sets the shipping city.</summary>
		/// <value>The shipping city.</value>
		public string ShippingCity { get; set; }

		public string ShippingState { get; set; }

		/// <summary>Gets or sets the shipping zip.</summary>
		/// <value>The shipping zip.</value>
		public string ShippingZip { get; set; }

		/// <summary>Gets or sets the name of the shipping contact.</summary>
		/// <value>The name of the shipping contact.</value>
		public string ShippingContactName { get; set; }

		/// <summary>Gets or sets the shipping contact phone.</summary>
		/// <value>The shipping contact phone.</value>
		public string ShippingContactPhone { get; set; }

		/// <summary>Gets or sets the shipping contact ext.</summary>
		/// <value>The shipping contact ext.</value>
		public string ShippingContactExt { get; set; }

		/// <summary>Gets or sets the shipping contact email.</summary>
		/// <value>The shipping contact email.</value>
		public string ShippingContactEmail { get; set; }

		/// <summary>Gets or sets the shipping contact fax.</summary>
		/// <value>The shipping contact fax.</value>
		public string ShippingContactFax { get; set; }

		/// <summary>Gets or sets the name of the billing.</summary>
		/// <value>The name of the billing.</value>
		public string BillingName { get; set; }

		/// <summary>Gets or sets the billing address1.</summary>
		/// <value>The billing address1.</value>
		public string BillingAddress1 { get; set; }

		/// <summary>Gets or sets the billing address2.</summary>
		/// <value>The billing address2.</value>
		public string BillingAddress2 { get; set; }

		/// <summary>Gets or sets the billing city.</summary>
		/// <value>The billing city.</value>
		public string BillingCity { get; set; }

		/// <summary>Gets or sets the state of the billing.</summary>
		/// <value>The state of the billing.</value>
		public string BillingState { get; set; }

		/// <summary>Gets or sets the billing zip.</summary>
		/// <value>The billing zip.</value>
		public string BillingZip { get; set; }

		/// <summary>Gets or sets the name of the billing contact.</summary>
		/// <value>The name of the billing contact.</value>
		public string BillingContactName { get; set; }

		/// <summary>Gets or sets the billing contact phone.</summary>
		/// <value>The billing contact phone.</value>
		public string BillingContactPhone { get; set; }

		/// <summary>Gets or sets the billing contact ext.</summary>
		/// <value>The billing contact ext.</value>
		public string BillingContactExt { get; set; }

		/// <summary>Gets or sets the billing contact email.</summary>
		/// <value>The billing contact email.</value>
		public string BillingContactEmail { get; set; }

		/// <summary>Gets or sets the billing contact fax.</summary>
		/// <value>The billing contact fax.</value>
		public string BillingContactFax { get; set; }

		/// <summary>Gets or sets the vendor identifier.</summary>
		/// <value>The vendor identifier.</value>
		public Guid? VendorId { get; set; }

		/// <summary>Gets or sets the vendor no.</summary>
		/// <value>The vendor no.</value>
		public string VendorNo { get; set; }

		/// <summary>Gets or sets the name of the vendor.</summary>
		/// <value>The name of the vendor.</value>
		public string VendorName { get; set; }

		/// <summary>Gets or sets the last updated.</summary>
		/// <value>The last updated.</value>
		public DateTime? LastUpdated { get; set; }

		/// <summary>Gets or sets the last updated by.</summary>
		/// <value>The last updated by.</value>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>Gets or sets the last name of the updated by user.</summary>
		/// <value>The last name of the updated by user.</value>
		public string LastUpdatedByUserName { get; set; }

		/// <summary>Gets or sets the date created.</summary>
		/// <value>The date created.</value>
		public DateTime? DateCreated { get; set; }

		/// <summary>Gets or sets the discount.</summary>
		/// <value>The discount.</value>
		public decimal? Discount { get; set; }

		/// <summary>Gets or sets the discount type identifier.</summary>
		/// <value>The discount type identifier.</value>
		public byte? DiscountTypeId { get; set; }

		/// <summary>Gets or sets the type of the discount.</summary>
		/// <value>The type of the discount.</value>
		public string DiscountType { get; set; }

		/// <summary>Gets or sets the sales tax.</summary>
		/// <value>The sales tax.</value>
		public decimal? SalesTax { get; set; }

		/// <summary>Gets or sets the sales tax identifier.</summary>
		/// <value>The sales tax identifier.</value>
		public byte? SalesTaxId { get; set; }

		/// <summary>Gets or sets the type of the sales tax.</summary>
		/// <value>The type of the sales tax.</value>
		public string SalesTaxType { get; set; }

		/// <summary>Gets or sets the shipping.</summary>
		/// <value>The shipping.</value>
		public decimal? Shipping { get; set; }

		/// <summary>Gets or sets the shipping type identifier.</summary>
		/// <value>The shipping type identifier.</value>
		public byte? ShippingTypeId { get; set; }

		/// <summary>Gets or sets the type of the shipping.</summary>
		/// <value>The type of the shipping.</value>
		public string ShippingType { get; set; }

		/// <summary>
		/// PO child entity. Is needed for correct work of odata endpoint with purchaseOrderItems segment
		/// </summary>
		public List<PurchaseOrderItemDTO> PurchaseOrderItems { get; set; }
	}
}
