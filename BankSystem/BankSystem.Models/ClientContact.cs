﻿using System.ComponentModel.DataAnnotations;

namespace BankSystem.Models
{
    public class ClientContact
    {
        public int Id { get; set; }

        public Client Owner { get; set; }

        public Client Target { get; set; }

        [MaxLength(1000, ErrorMessage = "A thousand chars are enough, dude!")]
        public string Description { get; set; }
    }
}