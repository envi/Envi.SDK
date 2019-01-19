using System;

namespace Api.Common.Entities.MatchedInvoices.DTO
{
	/// <summary>
	/// Represents a matched invoice entity.
	/// </summary>
	public class APMatchedInvoice
	{
		#region Public Properties

		/// <summary>
		/// Gets or sets a ap Matched Invoice Id.
		/// </summary>
		public Guid ApMatchedInvoiceId { get; set; }

		/// <summary>
		/// Gets or sets a purchase Order Id.
		/// </summary>
		public Guid PurchaseOrderId { get; set; }

		/// <summary>
		/// Gets or sets a purchase Order No.
		/// </summary>
		public string PurchaseOrderNo { get; set; }

		/// <summary>
		/// Gets or sets a sequence No.
		/// </summary>
		public int? SequenceNo { get; set; }

		/// <summary>
		/// Gets or sets a po Type.
		/// </summary>
		public string PoType { get; set; }

		/// <summary>
		/// Gets or sets a facility Id.
		/// </summary>
		public Guid FacilityId { get; set; }

		/// <summary>
		/// Gets or sets a facility No.
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Gets or sets a facility Name.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Gets or sets a location Id.
		/// </summary>
		public Guid LocationId { get; set; }

		/// <summary>
		/// Gets or sets a location No.
		/// </summary>
		public string LocationNo { get; set; }

		/// <summary>
		/// Gets or sets a location Name.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Gets or sets a vendor Id.
		/// </summary>
		public Guid VendorId { get; set; }

		/// <summary>
		/// Gets or sets a vendor No.
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Gets or sets a vendor Name.
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Gets or sets a invoice No.
		/// </summary>
		public string InvoiceNo { get; set; }

		/// <summary>
		/// Gets or sets a matched Invoice Status Id.
		/// </summary>
		public byte MatchedInvoiceStatusId { get; set; }

		/// <summary>
		/// Gets or sets a matched Invoice Status.
		/// </summary>
		public string MatchedInvoiceStatus { get; set; }

		/// <summary>
		/// Gets or sets a vendor Remit To Id.
		/// </summary>
		public Guid? VendorRemitToId { get; set; }

		/// <summary>
		/// Gets or sets a remit To No.
		/// </summary>
		public string RemitToNo { get; set; }

		/// <summary>
		/// Gets or sets a remit To Description.
		/// </summary>
		public string RemitToDescription { get; set; }

		/// <summary>
		/// Gets or sets a remit To Vendor No.
		/// </summary>
		public string RemitToVendorNo { get; set; }

		/// <summary>
		/// Gets or sets a credit Card Id.
		/// </summary>
		public Guid? CreditCardIDId { get; set; }

		/// <summary>
		/// Gets or sets a credit Card I D.
		/// </summary>
		public string CreditCardID { get; set; }

		/// <summary>
		/// Gets or sets a credit Card Description.
		/// </summary>
		public string CreditCardIDDescription { get; set; }

		/// <summary>
		/// Gets or sets a reference.
		/// </summary>
		public string Reference { get; set; }

		/// <summary>
		/// Gets or sets a notes.
		/// </summary>
		public string Notes { get; set; }

		/// <summary>
		/// Gets or sets a invoice Date.
		/// </summary>
		public DateTime? InvoiceDate { get; set; }

		/// <summary>
		/// Gets or sets a invoice Due Date.
		/// </summary>
		public DateTime? InvoiceDueDate { get; set; }

		/// <summary>
		/// Gets or sets a tracking Code.
		/// </summary>
		public string TrackingCode { get; set; }

		/// <summary>
		/// Gets or sets a invoice Validation Total.
		/// </summary>
		public decimal InvoiceValidationTotal { get; set; }

		/// <summary>
		/// Gets or sets a cer No Id.
		/// </summary>
		public Guid? CerNoId { get; set; }

		/// <summary>
		/// Gets or sets a cer No.
		/// </summary>
		public string CerNo { get; set; }

		/// <summary>
		/// Gets or sets a cer No Description.
		/// </summary>
		public string CerNoDescription { get; set; }

		/// <summary>
		/// Gets or sets a discount Amount.
		/// </summary>
		public decimal DiscountAmount { get; set; }

		/// <summary>
		/// Gets or sets a tax Amount.
		/// </summary>
		public decimal TaxAmount { get; set; }

		/// <summary>
		/// Gets or sets a shipping Amount.
		/// </summary>
		public decimal ShippingAmount { get; set; }

		/// <summary>
		/// Gets or sets a tax Expense G L Code.
		/// </summary>
		public string TaxExpenseGLCode { get; set; }

		/// <summary>
		/// Gets or sets a tax Accrual G L Code.
		/// </summary>
		public string TaxAccrualGLCode { get; set; }

		/// <summary>
		/// Gets or sets a discount G L Code.
		/// </summary>
		public string DiscountGLCode { get; set; }

		/// <summary>
		/// Gets or sets a tax Expense Amount.
		/// </summary>
		public decimal TaxExpenseAmount { get; set; }

		/// <summary>
		/// Gets or sets a ap Batch Id.
		/// </summary>
		public Guid? ApBatchId { get; set; }

		/// <summary>
		/// Gets or sets a ap Batch No.
		/// </summary>
		public string ApBatchNo { get; set; }

		/// <summary>
		/// Gets or sets a tax Code.
		/// </summary>
		public string TaxCode { get; set; }

		/// <summary>
		/// Gets or sets a received Invoice Id.
		/// </summary>
		public Guid? ReceivedInvoiceId { get; set; }

		/// <summary>
		/// Gets or sets a offset.
		/// </summary>
		public decimal Offset { get; set; }

		/// <summary>
		/// Gets or sets a offset G L Code.
		/// </summary>
		public string OffsetGLCode { get; set; }

		/// <summary>
		/// Gets or sets a created By.
		/// </summary>
		public Guid? CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets a Created By User Name.
		/// </summary>
		public string CreatedByUserName { get; set; }

		/// <summary>
		/// Gets or sets a date Created.
		/// </summary>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Gets or sets a last Updated.
		/// </summary>
		public DateTime LastUpdated { get; set; }

		/// <summary>
		/// Gets or sets a last Updated By.
		/// </summary>
		public Guid LastUpdatedBy { get; set; }

		/// <summary>
		/// Gets or sets a last Updated By User Name.
		/// </summary>
		public string LastUpdatedByUserName { get; set; }

		/// <summary>
		/// Gets or sets a submitted By.
		/// </summary>
		public Guid? SubmittedBy { get; set; }

		/// <summary>
		/// Gets or sets a submitted By User Name.
		/// </summary>
		public string SubmittedByUserName { get; set; }

		#endregion
	}
}
