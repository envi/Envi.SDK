using System;

namespace Api.Common.Entities.Usages.DTO
{
	/// <summary>
	/// Class that describes UsageItem.
	/// </summary>
	public class UsageItem
	{
		/// <summary>
		/// Get the usage item Id value.
		/// </summary>
		public Guid? UsageItemId { get; set; }

		/// <summary>
		/// Get the procedure code1 value.
		/// </summary>
		public string ProcedureCode1 { get; set; }

		/// <summary>
		/// Get the procedure name1 value.
		/// </summary>
		public string ProcedureName1 { get; set; }

		/// <summary>
		/// Get the procedure code2 value.
		/// </summary>
		public string ProcedureCode2 { get; set; }

		/// <summary>
		/// Get the procedure name2 value.
		/// </summary>
		public string ProcedureName2 { get; set; }

		/// <summary>
		/// Get or set the procedure1 Id value.
		/// </summary>
		public Guid? Procedure1Id { get; set; }

		/// <summary>
		/// Get or set the procedure2 Id value.
		/// </summary>
		public Guid? Procedure2Id { get; set; }

		/// <summary>
		/// Get the Usage Item created date value.
		/// </summary>
		public DateTime? Date { get; set; }

		/// <summary>
		/// Get or set the case no value.
		/// </summary>
		public string CaseNo { get; set; }

		/// <summary>
		/// Get or set the facility Id value.
		/// </summary>
		public Guid? FacilityId { get; set; }
		
		/// <summary>
		/// Get the name of the department.
		/// </summary>
		public string DepartmentName { get; set; }
		
		/// <summary>
		/// Get or set the department Id value.
		/// </summary>
		public Guid? DepartmentId { get; set; }

		/// <summary>
		/// Get or set the price extended value.
		/// </summary>
		public decimal? ExtendedPrice { get; set; }

		/// <summary>
		/// Get the patient value.
		/// </summary>
		public string Patient { get; set; }
		
		/// <summary>
		/// Get the name of the facility.
		/// </summary>
		public string FacilityName { get; set; }
		
		/// <summary>
		/// Get the facility no.
		/// </summary>
		public string FacilityNo { get; set; }
		
		/// <summary>
		/// Get the name of the doctor.
		/// </summary>
		public string DoctorName { get; set; }

		/// <summary>
		/// Get or set the doctor Id value.
		/// </summary>
		public Guid? DoctorId { get; set; }

		/// <summary>
		/// Get or set the vendor item no value.
		/// </summary>
		public string VendorItemNo { get; set; }

		/// <summary>
		/// Get or set the inventory description value.
		/// </summary>
		public string InventoryDescription { get; set; }
		
		/// <summary>
		/// Get the classification value.
		/// </summary>
		public string Classification { get; set; }
		
		/// <summary>
		/// Get or set the classification2 value.
		/// </summary>
		public string Classification2 { get; set; }

		/// <summary>
		/// Get or set the quantity value.
		/// </summary>
		public int? Quantity { get; set; }

		/// <summary>
		/// Get or set the uom value.
		/// </summary>
		public string UOM { get; set; }
		
		/// <summary>
		/// Get or set the price value.
		/// </summary>
		public decimal? Price { get; set; }
		
		/// <summary>
		/// Get or set the conversion factor value.
		/// </summary>
		public int? ConversionFactor { get; set; }

		/// <summary>
		/// Get the location no value.
		/// </summary>
		public string LocationNo { get; set; }
		
		/// <summary>
		/// Get the inventory no value.
		/// </summary>
		public string InventoryNo { get; set; }

		/// <summary>
		/// Get or set the manufacturer value.
		/// </summary>
		public string Manufacturer { get; set; }

		/// <summary>
		/// Get or set the manufacturer item no value.
		/// </summary>
		public string ManufacturerItemNo { get; set; }

		/// <summary>
		/// Get or set the tracking lot no value.
		/// </summary>
		public string LotNo { get; set; }
		
		/// <summary>
		/// Get or set the tracking serial no value.
		/// </summary>
		public string SerialNo { get; set; }

		/// <summary>
		/// Get or set the tracking expiration date value.
		/// </summary>
		public DateTime? ExpirationDate { get; set; }
		
		/// <summary>
		/// Get or set the item notes.
		/// </summary>
		public string ItemNotes { get; set; }
		
		/// <summary>
		/// Get the line no value.
		/// </summary>
		public int? LineNo { get; set; }
		
		/// <summary>
		/// Get or set the usage ordinal no value.
		/// </summary>
		public int? UsageOrdinalNo { get; set; }
		
		/// <summary>
		/// Get the usage ID value.
		/// </summary>
		public Guid? UsageId { get; set; }
	}
}
