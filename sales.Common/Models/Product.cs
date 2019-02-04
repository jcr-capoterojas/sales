namespace sales.Common.Models
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Description { get; set; }


        public Decimal Price { get; set; }

        
        public bool IsAvailable { get; set; }

        
        public DateTime PublishOn { get; set; }

        public override string ToString()
        {
            return this.Description;
        }
    }
}