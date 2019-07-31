using System;

namespace Api.Common.Entities.InventoryActivity.DTO
{
	/// <summary>
	/// Class that describes Inventory Activity.
	/// </summary>
	public class InventoryActivity
	{
		#region Public Properties

		/// <summary>
		/// Get or set the Inventory Activity Id value.
		/// </summary>
		public Guid InventoryActivityId { get; set; }

		/// <summary>
		/// Get or set the Activity Type value.
		/// </summary>
		public int ActivityTypeId { get; set; }

		/// <summary>
		/// Get or set the Activity Type Name value.
		/// </summary>
		public string ActivityTypeName { get; set; }

		/// <summary>
		/// Get or set the organization Id value.
		/// </summary>
		public Guid OrganizationId { get; set; }

		/// <summary>
		/// Get or set the Organization No value.
		/// </summary>
		public string OrganizationNo { get; set; }

		/// <summary>
		/// Get or set the name of the organization.
		/// </summary>
		public string OrganizationName { get; set; }

		/// <summary>
		/// Get or set the Facility Id value.
		/// </summary>
		public Guid FacilityId { get; set; }

		/// <summary>
		/// Get or set the Facility No value.
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Get or set the name of the Facility.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Gets or sets a inventory Group Id.
		/// </summary>
		public Guid InventoryGroupId { get; set; }

		/// <summary>
		/// Gets or sets a Inventory Group Name.
		/// </summary>
		public string InventoryGroupName { get; set; }

		/// <summary>
		/// Get or set the Inventory Id value.
		/// </summary>
		public Guid? InventoryId { get; set; }

		/// <summary>
		/// Get or set the Inventory No value.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Gets or sets a inventory Description.
		/// </summary>
		public string InventoryDescription { get; set; }

		/// <summary>
		/// Get or set the Inventory Location Id value.
		/// </summary>
		public Guid? InventoryLocationId { get; set; }

		/// <summary>
		/// Get or set the Location No value.
		/// </summary>
		public string LocationNo { get; set; }

		/// <summary>
		/// Get or set the name of the Location.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// Gets or sets the Inventory Vendor Id value.
		/// </summary>
		public Guid? InventoryVendorId { get; set; }

		/// <summary>
		/// Get or set the Vendor No value.
		/// </summary>
		public string VendorNo { get; set; }

		/// <summary>
		/// Get or set the name of the Vendor.
		/// </summary>
		public string VendorName { get; set; }

		/// <summary>
		/// Get or set the Reference No value.
		/// </summary>
		public string ReferenceNo { get; set; }

		/// <summary>
		/// Gets or sets the Patient Id value.
		/// </summary>
		public Guid? PatientId { get; set; }

		/// <summary>
		/// Get or set the Patient No value.
		/// </summary>
		public string PatientNo { get; set; }

		/// <summary>
		/// Gets or sets the Department Id value.
		/// </summary>
		public Guid? DepartmentId { get; set; }

		/// <summary>
		/// Get or set the Department No value.
		/// </summary>
		public string DepartmentNo { get; set; }

		/// <summary>
		/// Get or set the name of the Department.
		/// </summary>
		public string DepartmentName { get; set; }

		/// <summary>
		/// Get or set the Impact Quantity value.
		/// </summary>
		public int ImpactQuantity { get; set; }

		/// <summary>
		/// Get or set the stock uom value.
		/// </summary>
		public string StockUOM { get; set; }

		/// <summary>
		/// Get or set the Unit Cost value.
		/// </summary>
		public decimal UnitCost { get; set; }

		/// <summary>
		/// Get or set the Unit Price value.
		/// </summary>
		public decimal UnitPrice { get; set; }

		/// <summary>
		/// Get or set the expense ledger no.
		/// </summary>
		public string ExpenseLedgerNo { get; set; }

		/// <summary>
		/// Get or set the asset ledger no.
		/// </summary>
		public string AssetLedgerNo { get; set; }

		/// <summary>
		/// Get or set the GL Code value.
		/// </summary>
		public string GLCode { get; set; }

		/// <summary>
		/// Get or set the Lot No value.
		/// </summary>
		public string LotNo { get; set; }

		/// <summary>
		/// Get or set the Serial No value.
		/// </summary>
		public string SerialNo { get; set; }

		/// <summary>
		/// Get or set the Exp Date value.
		/// </summary>
		public DateTime? ExpDate { get; set; }

		/// <summary>
		/// Get or set the last updated value.
		/// </summary>
		public DateTime LastUpdated { get; set; }

		/// <summary>
		/// Get or set the last updated by value.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get or set the last name of the updated by.
		/// </summary>
		public string LastUpdatedByName { get; set; }

		/// <summary>
		/// Gets or sets a user Name.
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// Get or set the Quantity On Hand value.
		/// </summary>
		public int? QuantityOnHand { get; set; }

		/// <summary>
		/// Get or set the Source Entity Id value.
		/// </summary>
		public Guid? SourceEntityId { get; set; }

		/// <summary>
		/// Get or set the Submitted Entity Id value.
		/// </summary>
		public Guid? SubmittedEntityId { get; set; }

		/// <summary>
		/// Gets or sets a classification.
		/// </summary>
		public string Classification { get; set; }

		/// <summary>
		/// Gets or sets a classification2.
		/// </summary>
		public string Classification2 { get; set; }

		/// <summary>
		/// Gets or sets a ar Billing Code.
		/// </summary>
		public string ArBillingCode { get; set; }

		/// <summary>
		/// Gets or sets a hcpcs Code.
		/// </summary>
		public string HcpcsCode { get; set; }

		/// <summary>
		/// Gets or sets a unspsc Code.
		/// </summary>
		public string UnspscCode { get; set; }

		/// <summary>
		/// Gets or sets a is Latex.
		/// </summary>
		public bool IsLatex { get; set; }

		/// <summary>
		/// Gets or sets a default Issue U O M.
		/// </summary>
		public string DefaultIssueUOM { get; set; }

		/// <summary>
		/// Gets or sets a default Issue Conversion Factor.
		/// </summary>
		public int DefaultIssueConversionFactor { get; set; }

		/// <summary>
		/// Gets or sets a default Count U O M.
		/// </summary>
		public string DefaultCountUOM { get; set; }

		/// <summary>
		/// Gets or sets a default Count Conversion Factor.
		/// </summary>
		public int DefaultCountConversionFactor { get; set; }

		/// <summary>
		/// Gets or sets a default Expense Ledger No.
		/// </summary>
		public string DefaultExpenseLedgerNo { get; set; }

		/// <summary>
		/// Gets or sets a default Asset Ledger No.
		/// </summary>
		public string DefaultAssetLedgerNo { get; set; }

		/// <summary>
		/// Gets or sets a location U O M.
		/// </summary>
		public string LocationUOM { get; set; }

		/// <summary>
		/// Gets or sets a location Conversion Factor.
		/// </summary>
		public int LocationConversionFactor { get; set; }

		/// <summary>
		/// Gets or sets a item Type Id.
		/// </summary>
		public byte ItemTypeId { get; set; }

		/// <summary>
		/// Gets or sets a item Type Name.
		/// </summary>
		public string ItemTypeName { get; set; }

		/// <summary>
		/// Gets or sets a price Markup.
		/// </summary>
		public decimal PriceMarkup { get; set; }

		/// <summary>
		/// Gets or sets a price Markup Type.
		/// </summary>
		public string PriceMarkupType { get; set; }

		/// <summary>
		/// Gets or sets a min Quantity.
		/// </summary>
		public int MinQuantity { get; set; }

		/// <summary>
		/// Gets or sets a max Quantity.
		/// </summary>
		public int MaxQuantity { get; set; }

		/// <summary>
		/// Gets or sets a safety Stock.
		/// </summary>
		public int? SafetyStock { get; set; }

		/// <summary>
		/// Gets or sets a bin Shelf.
		/// </summary>
		public string BinShelf { get; set; }

		/// <summary>
		/// Gets or sets a sync Flag.
		/// </summary>
		public bool SyncFlag { get; set; }

		/// <summary>
		/// Gets or sets a disable Purchasing.
		/// </summary>
		public bool DisablePurchasing { get; set; }

		/// <summary>
		/// Gets or sets a is Billable.
		/// </summary>
		public bool IsBillable { get; set; }

		/// <summary>
		/// Gets or sets a is Taxable.
		/// </summary>
		public bool IsTaxable { get; set; }

		/// <summary>
		/// Gets or sets a vendor Item No.
		/// </summary>
		public string VendorItemNo { get; set; }

		/// <summary>
		/// Gets or sets a vendor U O M.
		/// </summary>
		public string VendorUOM { get; set; }

		/// <summary>
		/// Gets or sets a vendor Conversion Factor.
		/// </summary>
		public int VendorConversionFactor { get; set; }

		/// <summary>
		/// Gets or sets a priority.
		/// </summary>
		public int Priority { get; set; }

		/// <summary>
		/// Gets or sets a contract Number.
		/// </summary>
		public string ContractNo { get; set; }

		/// <summary>
		/// Gets or sets a contract Expiration Date.
		/// </summary>
		public DateTime? ContractExpirationDate { get; set; }

		/// <summary>
		/// Gets or sets a manufacturer Id.
		/// </summary>
		public Guid? ManufacturerId { get; set; }

		/// <summary>
		/// Gets or sets a manufacturer No.
		/// </summary>
		public string ManufacturerNo { get; set; }

		/// <summary>
		/// Gets or sets a manufacturer Name.
		/// </summary>
		public string ManufacturerName { get; set; }

		/// <summary>
		/// Gets or sets a manufacturer Item No.
		/// </summary>
		public string ManufacturerItemNo { get; set; }

		/// <summary>
		/// Gets or sets a gtin.
		/// </summary>
		public string Gtin { get; set; }

		/// <summary>
		/// Gets or sets a ndc Number.
		/// </summary>
		public string NdcNo { get; set; }

		/// <summary>
		/// Gets or sets a department Glcode.
		/// </summary>
		public string DepartmentGlcode { get; set; }

		/// <summary>
		/// Gets or sets a transaction Quantity.
		/// </summary>
		public int TransactionQuantity { get; set; }

		/// <summary>
		/// Gets or sets a transaction U O M.
		/// </summary>
		public string TransactionUOM { get; set; }

		/// <summary>
		/// Gets or sets a transaction C F.
		/// </summary>
		public int TransactionCF { get; set; }

		/// <summary>
		/// Gets or sets a extended Cost.
		/// </summary>
		public decimal ExtendedCost { get; set; }

		#endregion

	}
}
