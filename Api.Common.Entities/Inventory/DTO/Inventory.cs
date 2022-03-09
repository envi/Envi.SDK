using System;
using System.Collections.Generic;
using Api.Common.Entities.InventoryLocations.DTO;
using Api.Common.Entities.InventoryVendors.DTO;

namespace Api.Common.Entities.Inventory.DTO
{
	/// <summary>
	/// Class that describes Inventory.
	/// </summary>
	public class Inventory
	{
		/// <summary>
		/// Get or set the inventory Id value.
		/// </summary>
		public Guid? InventoryId { get; set; }

		/// <summary>
		/// Get or set the organization Id value.
		/// </summary>
		public Guid? OrganizationId { get; set; }

		/// <summary>
		/// Get or set the name of the organization.
		/// </summary>
		public string OrganizationName { get; set; }

		/// <summary>
		/// Get or set the inventory group Id value.
		/// </summary>
		public Guid? InventoryGroupId { get; set; }

		/// <summary>
		/// Get or set the inventory no value.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the inventory group.
		/// </summary>
		public string InventoryGroupName { get; set; }

		/// <summary>
		/// Get or set the inventory description value.
		/// </summary>
		public string InventoryDescription { get; set; }

		/// <summary>
		/// Get or set the inventory description2 value.
		/// </summary>
		public string InventoryDescription2 { get; set; }

		/// <summary>
		/// Get or set the stock uom value.
		/// </summary>
		public string StockUOM { get; set; }

		/// <summary>
		/// Get or set the ar billing code value.
		/// </summary>
		public string ARBillingCode { get; set; }

		/// <summary>
		/// Get or set the HCPCS code value.
		/// </summary>
		public string HCPCSCode { get; set; }

		/// <summary>
		/// Get or set the notes value.
		/// </summary>
		public string Notes { get; set; }

		/// <summary>
		/// Get or set the date added.
		/// </summary>
		public DateTimeOffset? DateAdded { get; set; }

		/// <summary>
		/// Get or set the added Id value.
		/// </summary>
		public Guid? AddedId { get; set; }

		/// <summary>
		/// Get or set the name of the added by.
		/// </summary>
		public string AddedByName { get; set; }

		///// <summary>
		///// Get or set the last updated.
		///// </summary>
		public DateTimeOffset? LastUpdated { get; set; }

		/// <summary>
		/// Get or set the last updated by.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get or set the last name of the updated by.
		/// </summary>
		public string LastUpdatedByName { get; set; }

		/// <summary>
		/// Get or set Inventory active status.
		/// </summary>
		public bool? ActiveStatus { get; set; }

		/// <summary>
		/// Get or set the unspsc value.
		/// </summary>
		public string UNSPSCCode { get; set; }

		/// <summary>
		/// Get or set IsLatex value.
		/// </summary>
		public bool? IsLatex { get; set; }

		/// <summary>
		/// Get or set the classification Id value.
		/// </summary>
		public Guid? ClassificationId { get; set; }

		/// <summary>
		/// Get or set the name of the classification.
		/// </summary>
		public string ClassificationName { get; set; }

		/// <summary>
		/// Get or set the classification2 Id value.
		/// </summary>
		public Guid? Classification2Id { get; set; }

		/// <summary>
		/// Get or set the name of the classification2.
		/// </summary>
		public string Classification2Name { get; set; }
		/// <summary>
		/// Get or set the default expense ledger no.
		/// </summary>
		public string DefaultExpenseLedgerNo { get; set; }

		/// <summary>
		/// Get or set the default asset ledger no.
		/// </summary>
		public string DefaultAssetLedgerNo { get; set; }

		/// <summary>
		/// Get or set the periop category Id value.
		/// </summary>
		public Guid? PeriopCategoryId { get; set; }

		/// <summary>
		/// Get or set the periop category.
		/// </summary>
		public string PeriopItemCategory { get; set; }

		/// <summary>
		/// Get or set the system type Id value.
		/// </summary>
		public byte? SystemTypeId { get; set; }

		/// <summary>
		/// Get or set the type of the system.
		/// </summary>
		public string SystemType { get; set; }

		/// <summary>
		/// Get or set DefaultIsBillable value.
		/// </summary>
		public bool? DefaultIsBillable { get; set; }

		/// <summary>
		/// Get or set the inventory locations list.
		/// </summary>
		public List<InventoryLocation> InventoryLocations { get; set; }

		/// <summary>
		/// Get or set the inventory vendors.
		/// </summary>
		public List<InventoryVendor> InventoryVendors { get; set; }
	}
}