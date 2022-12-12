﻿using Microsoft.AspNetCore.Components.Routing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMSSQL.Models
{
    public class LocalUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        public int HasAmountOfBooks { get; set; }
        virtual public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        [CustomValidation(typeof(LocalUser), "RegistrationValidation")]
        [Display(Name = "Registration Date")]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Expiration Date")]
        public DateTime? ExpirationDate { get; set; }

        [Display(Name = "Skola")]
        public double Debt{
            get
            {
                double skola = 0;
                foreach (var reservacion in Reservations)
                {
                    if (reservacion.LocalUserId == Id)
                    {
                         skola += reservacion.DelayFine;
                    }
                }
                return skola;
            }
        }

        public int MAX_BORROWED_BOOKS = 5;

        public double MAX_DEBT = 50;

        public int BORROW_PERIOD_DAYS = 28;

        [NotMapped]
        public bool IsActive
        {
            get
            {
                if (ExpirationDate.HasValue)
                {
                    if (ExpirationDate < DateTime.Now)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        [NotMapped]
        public int ExpirationDays
        {
            get
            {
                if (ExpirationDate.HasValue)
                {
                    return (int)((DateTime)DateTime.Now - (DateTime)ExpirationDate).TotalDays;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static ValidationResult RegistrationValidation(DateTime? rDate)
        {
            if (rDate == null)
            {
                return ValidationResult.Success;
            }
            if (rDate <= DateTime.Today)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Registration Date cannot be in future");
        }
    }

}