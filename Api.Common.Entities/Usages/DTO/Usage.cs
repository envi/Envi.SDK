using System;

namespace Api.Common.Entities.Usages.DTO
{
	public class Usage
	{
		/// <summary>
		/// Usage identidier
		/// </summary>
		public Guid? UsageId { get; set; }

		/// <summary>
		/// Gets or sets the usage Ordinal No
		/// </summary>
		public int? UsageOrdinalNo { get; set; }

		/// <summary>
		/// Holds facility No of the usage
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Holds facility Name of the usage
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Holds Department No of the usage
		/// </summary>
		public string DepartmentNo { get; set; }

		/// <summary>
		/// Holds Department Name of the usage
		/// </summary>
		public string DepartmentName { get; set; }

		/// <summary>
		/// Patient number
		/// </summary>
		public string PatientNo { get; set; }

		/// <summary>
		/// Usage number.
		/// </summary>
		public string UsageNo { get; set; }

		/// <summary>
		/// Holds Physician Number
		/// </summary>
		public string PhysicianNo { get; set; }

		/// <summary>
		/// Holds Schedule Number
		/// </summary>
		public string ScheduleNo { get; set; }

		/// <summary>
		/// Holds First Name of a Physician
		/// </summary>
		public string PhysicianFirstName { get; set; }

		/// <summary>
		/// Holds Last Name of a Physician
		/// </summary>
		public string PhysicianLastName { get; set; }

		/// <summary>
		/// Usage Date.
		/// </summary>
		public DateTime? UsageDate { get; set; }

		/// <summary>
		/// Holds Usage Type
		/// </summary>
		public byte? UsageType { get; set; }

		/// <summary>
		/// Case number
		/// </summary>
		public string CaseNo { get; set; }

		/// <summary>
		/// Holds department PK
		/// </summary>
		public Guid? DepartmentId { get; set; }

		/// <summary>
		/// Holds FacilityPK
		/// </summary>
		public Guid? FacilityId { get; set; }

		/// <summary>
		/// Usage's Reference
		/// </summary>
		public string Reference { get; set; }

		/// <summary>
		/// Usage's Tracking Code
		/// </summary>
		public string TrackingCode { get; set; }
	}
}
