using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Queue : IValidatableObject
    {
        public int Id { get; set; }

        
        public int UserId { get; set; }
        public Users user { get; set; }

        [Required]
        [Display(Name = "Date")]        
        [Remote("VerifyQueueDate","HomeContoller",ErrorMessage = "Queue date must be greater than now.")]
        public DateTime QueueDate { get; set; }

        [Display(Name = "Update Date")]
        public DateTime InsertDate { get; set; }

        [NotMapped]
        public bool IsMine { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (QueueDate < DateTime.Now)
            {
                yield return new ValidationResult(
                    $"Queue date must be greate than now",
                    new[] { nameof(UserId) });
            }
        }
    }

}
