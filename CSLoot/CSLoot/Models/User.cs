using System;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace CSLoot.Models
{
    public class User
    {
        public User()
        {

        }

        public int Id { get; set; }
        public string UserName { get; set; } = "";
        public double Balance { get; set; }
        public required string IdentityUserId { get; set; }

        [JsonIgnore]
        public virtual IdentityUser? IdentityUser { get; set; }

        // TODO: Ajouter la logique d'un inventaire.
    }
}
