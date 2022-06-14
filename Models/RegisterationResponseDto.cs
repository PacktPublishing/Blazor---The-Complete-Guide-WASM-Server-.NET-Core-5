using System.Collections.Generic;

namespace Models
{
    public class RegisterationResponseDTO
    {
        public bool IsRegisterationSuccessful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
