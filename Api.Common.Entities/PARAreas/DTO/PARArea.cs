using System;

namespace Api.Common.Entities.PARAreas.DTO
{
	/// <summary>
	/// Class that describes PARArea
	/// </summary>
	public class PARArea
	{
		/// <summary>
		/// Get or set PARArea Id
		/// </summary>
		public Guid PARAreaId { get; set; }

		/// <summary>
		/// Get or set PARArea number.
		/// </summary>
		public string PARAreaNo { get; set; }

		/// <summary>
		/// Get or set PARArea Name
		/// </summary>
		public string PARAreaName { get; set; }

		/// <summary>
		/// Get or set Facility Id
		/// </summary>
		public Guid FacilityId { get; set; }

		/// <summary>
		/// Get or set Facility Number
		/// </summary>
		public string FacilityNo { get; set; }

		/// <summary>
		/// Get or set Facility Name
		/// </summary>
		public string FacilityName { get; set; }

		/// <summary>
		/// Get or set Department Id
		/// </summary>
		public Guid? DepartmentId { get; set; }

		/// <summary>
		/// Get or set Department Number
		/// </summary>
		public string DepartmentNo { get; set; }

		/// <summary>
		/// Get or set Department Name
		/// </summary>
		public string DepartmentName { get; set; }

		/// <summary>
		/// Get or set GL Code
		/// </summary>
		public string GLCode { get; set; }

		/// <summary>
		/// Get or set Reference
		/// </summary>
		public string Reference { get; set; }

		/// <summary>
		/// Get or set PARArea active status
		/// </summary>
		public bool ActiveStatus { get; set; }

		/// <summary>
		/// Get or set the created date.
		/// </summary>
		public DateTime? DateCreated { get; set; }

		/// <summary>
		/// Get or set the created by.
		/// </summary>
		public Guid? CreatedBy { get; set; }

		/// <summary>
		/// Get or set first and last name of the created by user.
		/// </summary>
		public string CreatedByName { get; set; }

		/// <summary>
		/// Get or set the last updated.
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Get or set the last updated by.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Get or set first and last name of the last updated by user.
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}
