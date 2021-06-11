/*
 * Abdullah Mutaz Alshawa
 * 6/9/2021
 * Pets
 */
namespace Lab4WebApplication.Models.View
{
    using System;

    public partial class Pet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime NextCheckup { get; set; }

        public string VetName { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
