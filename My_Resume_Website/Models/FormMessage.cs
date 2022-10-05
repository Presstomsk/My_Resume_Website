using System;

namespace My_Resume_Website.Models
{
    public record FormMessage
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
    }
}
