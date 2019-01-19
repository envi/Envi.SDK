using System;

namespace Api.Common.Entities.Usages.DTO
{
	/// <summary>
	/// Class Usage.
	/// </summary>
	public class Usage
	{
		/// <summary>
		/// Gets or sets the usage identifier.
		/// </summary>
		public Guid? UsageId { get; set; }

		/// <summary>
		/// Gets or sets the usage Ordinal No
		/// </summary>
		public int? UsageOrdinalNo { get; set; }

		/// <summary>
		/// Gets or sets the facility no.
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the facility.
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Gets or sets the department no.
		/// </summary>
		public string DepartmentNo { get; set; }

		/// <summary>
		/// Gets or sets the name of the department.
		/// </summary>
		public string DepartmentName { get; set; }


		/// <summary>
		/// Gets or sets the patient no.
		/// </summary>
		public string PatientNo { get; set; }

		/// <summary>
		/// Gets or sets the usage no.
		/// </summary>
		public string UsageNo { get; set; }

		/// <summary>
		/// Gets or sets the physician no.
		/// </summary>
		public string PhysicianNo { get; set; }

		/// <summary>
		/// Gets or sets the schedule no.
		/// </summary>
		public string ScheduleNo { get; set; }

		/// <summary>
		/// Gets or sets the first name of the physician.
		/// </summary>
		public string PhysicianFirstName { get; set; }

		/// <summary>
		/// Gets or sets the last name of the physician.
		/// </summary>
		public string PhysicianLastName { get; set; }

		/// <summary>
		/// Gets or sets the usage date.
		/// </summary>
		public DateTime? UsageDate { get; set; }

		/// <summary>
		/// Gets or sets the type of the usage.
		/// </summary>
		public byte? UsageType { get; set; }

		/// <summary>
		/// Gets or sets the case no.
		/// </summary>
		public string CaseNo { get; set; }

		/// <summary>
		/// Gets or sets the department identifier.
		/// </summary>
		public Guid? DepartmentId { get; set; }

		/// <summary>
		/// Gets or sets the facility identifier.
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		public string Reference { get; set; }

		/// <summary>
		/// Gets or sets the tracking code.
		/// </summary>
		public string TrackingCode { get; set; }
	}
}
