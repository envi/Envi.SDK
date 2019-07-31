using System;

namespace Api.Common.Entities.MatchedInvoices.DTO
{
	public class APMatchedInvoiceItem
	{
		#region Public Properties

		/// <summary>
		/// Gets or sets a matched Invoice Item Id.
		/// </summary>
		public Guid APMatchedInvoiceItemId { get; set; }

		/// <summary>
		/// Gets or sets an invoice item's line item number.
		/// </summary>
		public int? MatchedInvoiceItemNo { get; set; }

		/// <summary>
		/// Gets or sets a matched Invoice Id.
		/// </summary>
		public Guid MatchedInvoiceId { get; set; }

		/// <summary>
		/// Gets or sets a matched Invoice No.
		/// </summary>
		public string MatchedInvoiceNo { get; set; }

		/// <summary>
		/// Gets or sets a purchase Order Id.
		/// </summary>
		public Guid PurchaseOrderId { get; set; }

		/// <summary>
		/// Gets or sets a purchase Order No.
		/// </summary>
		public string PurchaseOrderNo { get; set; }

		/// <summary>
		/// Gets or sets a po Receipt Item Id.
		/// </summary>
		public Guid? PoReceiptItemId { get; set; }

		/// <summary>
		/// Gets or sets a Return Item Id.
		/// </summary>
		public Guid? ReturnItemId { get; set; }

		/// <summary>
		/// Gets or sets a invoice Quantity.
		/// </summary>
		public int InvoiceQuantity { get; set; }

		/// <summary>
		/// Gets or sets a invoice U O M.
		/// </summary>
		public string InvoiceUOM { get; set; }

		/// <summary>
		/// Gets or sets a invoice Conversion Factor.
		/// </summary>
		public int InvoiceConversionFactor { get; set; }

		/// <summary>
		/// Gets or sets a invoice Price.
		/// </summary>
		public decimal InvoicePrice { get; set; }

		/// <summary>
		/// Gets or sets a notes.
		/// </summary>
		public string Notes { get; set; }

		/// <summary>
		/// Gets or sets a department G L Code.
		/// </summary>
		public string DepartmentGLCode { get; set; }

		/// <summary>
		/// Gets or sets a gl Code.
		/// </summary>
		public string GlCode { get; set; }

		/// <summary>
		/// Gets or sets a line Item Type Id.
		/// </summary>
		public byte LineItemTypeId { get; set; }

		/// <summary>
		/// Gets or sets a line Item Type.
		/// </summary>
		public string LineItemType { get; set; }

		/// <summary>
		/// Gets or sets a qty Approval Type Id.
		/// </summary>
		public byte QtyApprovalTypeId { get; set; }

		/// <summary>
		/// Gets or sets a qty Approval Type.
		/// </summary>
		public string QtyApprovalType { get; set; }

		/// <summary>
		/// Gets or sets a price Approval Type Id.
		/// </summary>
		public byte PriceApprovalTypeId { get; set; }

		/// <summary>
		/// Gets or sets a price Approval Type.
		/// </summary>
		public string PriceApprovalType { get; set; }

		/// <summary>
		/// Gets or sets a inventory No.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Gets or sets a inventory Description.
		/// </summary>
		public string InventoryDescription { get; set; }

		/// <summary>
		/// Gets or sets a vendor Item No.
		/// </summary>
		public string VendorItemNo { get; set; }

		/// <summary>
		/// Gets or sets a manufacturer Name.
		/// </summary>
		public string ManufacturerName { get; set; }

		/// <summary>
		/// Gets or sets a manufacturer Item No.
		/// </summary>
		public string ManufacturerItemNo { get; set; }

		/// <summary>
		/// Gets or sets a date Created.
		/// </summary>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Gets or sets a created By.
		/// </summary>
		public Guid CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets a created By Name.
		/// </summary>
		public string CreatedByName { get; set; }

		/// <summary>
		/// Gets or sets a last Updated.
		/// </summary>
		public DateTime LastUpdated { get; set; }

		/// <summary>
		/// Gets or sets a last Updated By.
		/// </summary>
		public Guid LastUpdatedBy { get; set; }

		/// <summary>
		/// Gets or sets a last Updated By Name.
		/// </summary>
		public string LastUpdatedByName { get; set; }

		/// <summary>
		/// Gets or sets a is Taxable.
		/// </summary>
		public bool IsTaxable { get; set; }

		#endregion
	}
}
