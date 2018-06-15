using System;

namespace Api.Common.Entities.Facilities.DTO
{
	/// <summary>
	/// Class that describes Facility.
	/// </summary>
	public class Facility
	{
		/// <summary>
		/// Get or set the facility Id value.
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Get or set the organization Id value.
		/// </summary>
		public Guid? OrganizationId { get; set; }

		/// <summary>
		/// Get or set the organization no value.
		/// </summary>
		public string OrganizationNo { get; set; }

		/// <summary>
		/// Get or set the name of the organization.
		/// </summary>
		public string OrganizationName { get; set; }

		/// <summary>
		/// Get or set the name of the facility.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Get or set the facility no value.
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Get or set the address1 value.
		/// </summary>
		public string Address1 { get; set; }

		/// <summary>
		/// Get or set the address2 value.
		/// </summary>
		public string Address2 { get; set; }

		/// <summary>
		/// Get or set the city value.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// Get or set the state value.
		/// </summary>
		public string State { get; set; }

		/// <summary>
		/// Get or set the zip value.
		/// </summary>
		public string Zip { get; set; }

		/// <summary>
		/// Get or set the country value.
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		/// Get or set the tax expense code template.
		/// </summary>
		public string TaxExpenseCodeTemplate { get; set; }

		/// <summary>
		/// Get or set the tax accrual code template.
		/// </summary>
		public string TaxAccrualCodeTemplate { get; set; }

		/// <summary>
		/// Get or set the discount code temporary.
		/// </summary>
		public string DiscountCodeTemp { get; set; }

		/// <summary>
		/// Get or set the shipping code template.
		/// </summary>
		public string ShippingCodeTemplate { get; set; }

		/// <summary>
		/// Get or set the offset code template.
		/// </summary>
		public string OffsetCodeTemplate { get; set; }

		/// <summary>
		/// Get or set the patient display template.
		/// </summary>
		public string PatientDisplayTemplate { get; set; }

		/// <summary>
		/// Get or set the pogl code display template.
		/// </summary>
		public string POGLCodeDisplayTemplate { get; set; }

		/// <summary>
		/// Get or set the po dept display template.
		/// </summary>
		public string PODeptDisplayTemplate { get; set; }

		/// <summary>
		/// Get or set a value of facility active status.
		/// </summary>
		public bool? ActiveStatus { get; set; }

		/// <summary>
		/// Get or set the inventory group Id value.
		/// </summary>
		public Guid? InventoryGroupId { get; set; }

		/// <summary>
		/// Get or set the inventory group no value.
		/// </summary>
		public string InventoryGroupNo { get; set; }

		/// <summary>
		/// Get or set the name of the inventory group.
		/// </summary>
		public string InventoryGroupName { get; set; }

		/// <summary>
		/// Get or set the Accounts Payable tolerance level.
		/// </summary>
		public decimal? APToleranceLevel { get; set; }

		/// <summary>
		/// Get or set the type of the Accounts Payable tolerance level.
		/// </summary>
		public byte? APToleranceLevelType { get; set; }

		/// <summary>
		/// Get or set the  Accounts Payable tolerance level type value.
		/// </summary>
		public string APToleranceLevelTypeValue { get; set; }

		/// <summary>
		/// Get or set the  Accounts Payable tolerance level2 value.
		/// </summary>
		public decimal? APToleranceLevel2 { get; set; }

		/// <summary>
		/// Get or set the type of the Accounts Payable tolerance level2.
		/// </summary>
		public byte? APToleranceLevel2Type { get; set; }

		/// <summary>
		/// Get or set the  Accounts Payable tolerance level2 type value.
		/// </summary>
		public string APToleranceLevel2TypeValue { get; set; }

		/// <summary>
		/// Get or set the  Accounts Payable free formed tolerance level value.
		/// </summary>
		public decimal? APFreeFormedToleranceLevel { get; set; }

		/// <summary>
		/// Get or set the type of the Accounts Payable free formed tolerance level.
		/// </summary>
		public byte? APFreeFormedToleranceLevelType { get; set; }

		/// <summary>
		/// Get or set the Accounts Payable free formed tolerance level type value.
		/// </summary>
		public string APFreeFormedToleranceLevelTypeValue { get; set; }

		/// <summary>
		/// Get or set the Accounts Payable free formed tolerance level2 value.
		/// </summary>
		public decimal? APFreeFormedToleranceLevel2 { get; set; }

		/// <summary>
		/// Get or set the type of the Accounts Payable free formed tolerance level2.
		/// </summary>
		public byte? APFreeFormedToleranceLevel2Type { get; set; }

		/// <summary>
		/// Get or set the Accounts Payable free formed tolerance level2 type value.
		/// </summary>
		public string APFreeFormedToleranceLevel2TypeValue { get; set; }

		/// <summary>
		/// Get or set the Accounts Payable offset tolerance value.
		/// </summary>
		public decimal? APOffsetTolerance { get; set; }

		/// <summary>
		/// Get or set the type of the Accounts Payable offset tolerance.
		/// </summary>
		public byte? APOffsetToleranceType { get; set; }

		/// <summary>
		/// Get or set the Accounts Payable offset tolerance type value.
		/// </summary>
		public string APOffsetToleranceTypeValue { get; set; }

		/// <summary>
		/// Get or set the type of the tax.
		/// </summary>
		public byte? TaxType { get; set; }

		/// <summary>
		/// Get or set the tax type value.
		/// </summary>
		public string TaxTypeValue { get; set; }

		/// <summary>
		/// Get or set the tax amount.
		/// </summary>
		public decimal? TaxAmount { get; set; }

		/// <summary>
		/// Get or set the type of the tax expense.
		/// </summary>
		public byte? TaxExpenseType { get; set; }

		/// <summary>
		/// Get or set the tax expense type value.
		/// </summary>
		public string TaxExpenseTypeValue { get; set; }

		/// <summary>
		/// Get or set the tax expense amount.
		/// </summary>
		public decimal? TaxExpenseAmount { get; set; }

		/// <summary>
		/// Get or set the facility no xref value.
		/// </summary>
		public string FacilityNoXref { get; set; }

		/// <summary>
		/// Get or set a value indicating whether[tax shipping is used.
		/// </summary>
		public bool? TaxShipping { get; set; }

		/// <summary>
		/// Get or set the Purchase Order GL validation.
		/// </summary>
		public string POGlValidation { get; set; }

		/// <summary>
		/// Get or set the Purchase Order GL validation message.
		/// </summary>
		public string POGlValidationMsg { get; set; }

		/// <summary>
		/// Get or set the Capital Purchase Order GL validation.
		/// </summary>
		public string CapitalPOGlValidation { get; set; }

		/// <summary>
		/// Get or set the Capital Purchase Order GL validation message.
		/// </summary>
		public string CapitalPOGlValidationMsg { get; set; }

		/// <summary>
		/// Get or set the time zone Id value.
		/// </summary>
		public Guid? TimeZoneId { get; set; }

		/// <summary>
		/// Get the time zone value.
		/// </summary>
		public string TimeZone { get; set; }

		/// <summary>
		/// Get or set the Preference Card matching type.
		/// </summary>
		public byte? PreferenceCardMatching { get; set; }

		/// <summary>
		/// Get or set the Preference Card matching type value.
		/// </summary>
		public string PreferenceCardMatchingValue { get; set; }

		/// <summary>
		/// Get or set the date created.
		/// </summary>
		/// <value>The date created.</value>
		public DateTime? DateCreated { get; set; }

		/// <summary>
		/// Get the facility creator Id.
		/// </summary>
		public Guid? CreatedBy { get; set; }

		/// <summary>
		/// Get the name of facility creator.
		/// </summary>
		public string CreatedByName { get; set; }

		/// <summary>
		/// Get the last updated date.
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Get or set the last facility updator Id value.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get or set the name of the last facility updator.
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}