using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Client.Models.ApiModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? Gender { get; set; }
        public string? Birthdate { get; set; }
        public int? Age { get; set; }
    }
}
