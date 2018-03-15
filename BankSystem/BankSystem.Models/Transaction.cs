﻿using System;
using System.ComponentModel.DataAnnotations;
using BankSystem.Models.Enums;

namespace BankSystem.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Transaction should have sender.")]
        public virtual BankAccount Sender { get; set; }

        [Required(ErrorMessage = "Transaction should have receiver.")]
        public virtual BankAccount Receiver { get; set; }

        [Range(typeof(decimal), "0.01", "1000001", ErrorMessage = "Transaction money amount should be between 0.01 and 1000001")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Transaction should have currency type.")]
        public Currency? Currency { get; set; }

        [Required(ErrorMessage = "Transaction should hava date.")]
        public DateTime? Date { get; set; }

        public bool IsDeleted { get; set; }
    }
}
