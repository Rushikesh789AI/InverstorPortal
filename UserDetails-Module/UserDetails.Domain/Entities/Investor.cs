using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDetails.Domain.Entities
{
    [Table("investors")]
    public class Investor
    {
        [Key]
        [Column("investor_id")]
        public Guid InvestorId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; } = null!;

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; } = null!;

        [Column("gender")]
        public string Gender { get; set; } = null!;

        [Column("email")]
        public string Email { get; set; } = null!;

        [Column("country_name")]
        public string CountryName { get; set; } = null!;

        [Column("mobile")]
        public string Mobile { get; set; } = null!;

        [Column("identity_proof_type")]
        public string IdentityProofType { get; set; } = null!;

        [Column("identity_proof_number")]
        public string IdentityProofNumber { get; set; } = null!;

        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Column("password")]
        public string Password { get; set; } = null!;

        [Column("is_active")]
        public bool? IsActive { get; set; }

        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime? CreatedOn { get; set; }

        [Column("modified_by")]
        public string? ModifiedBy { get; set; }

        [Column("modified_date")]
        public DateTime? ModifiedDate { get; set; }

        [Column("deactivation_by")]
        public string? DeactivationBy { get; set; }

        [Column("deactivation_date")]
        public DateTime? DeactivationDate { get; set; }
    }
}