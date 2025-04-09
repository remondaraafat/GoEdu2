using System.ComponentModel.DataAnnotations;

namespace GoEdu.ViewModel
{
    public class VMLogin
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
