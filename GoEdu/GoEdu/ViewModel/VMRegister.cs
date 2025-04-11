using System.ComponentModel.DataAnnotations;

namespace GoEdu.ViewModel
{
    public class VMRegister
    {
        // اسم المستخدم (مطلوب، طول محدد، أحرف وأرقام فقط)
        [Required(ErrorMessage = "اسم المستخدم مطلوب!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "يجب أن يكون اسم المستخدم بين 3 و50 حرفًا")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "يجب أن يحتوي اسم المستخدم على أحرف وأرقام فقط (بدون مسافات أو رموز)")]
        public string UserName { get; set; }

        // كلمة المرور (مطلوبة، طول محدد، نوع Password)
        [Required(ErrorMessage = "كلمة المرور مطلوبة!")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "كلمة المرور يجب أن تكون 6 أحرف على الأقل")]
        [MaxLength(20, ErrorMessage = "كلمة المرور يجب ألا تزيد عن 20 حرفًا")]
        public string Password { get; set; }

        // تأكيد كلمة المرور (مطابقة لكلمة المرور)
        [Required(ErrorMessage = "تأكيد كلمة المرور مطلوب!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        public string ConfirmPassword { get; set; }

        // البريد الإلكتروني (مطلوب، صيغة صحيحة)
        [Required(ErrorMessage = "البريد الإلكتروني مطلوب!")]
        [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صحيح")]
        public string Email { get; set; }

        // العمر (مطلوب، بين 1 و100)
        [Required(ErrorMessage = "العمر مطلوب!")]
        [Range(1, 100, ErrorMessage = "العمر يجب أن يكون بين 1 و100")]
        public int Age { get; set; }

        // العنوان (اختياري)
        public string? Address { get; set; }

        // رقم الهاتف (مطلوب، صيغة صحيحة)
        [Required(ErrorMessage = "رقم الهاتف مطلوب!")]
        [RegularExpression(@"^\+?[0-9]{7,14}$", ErrorMessage = "رقم الهاتف غير صالح (يجب أن يكون بين 7 و14 رقمًا)")]
        public string Phone { get; set; }

        // رقم ولي الأمر (اختياري، صيغة صحيحة إن وُجد)
        [RegularExpression(@"^\+?[0-9]{7,14}$", ErrorMessage = "رقم ولي الأمر غير صالح")]
        public string? ParentPhone { get; set; }

        // صورة المستخدم (اختيارية، للاستخدام الداخلي)
        public string? ImageUrl { get; internal set; }

        // هل هو مُدرّس؟ (حقل منطقي)
        public bool IsInstructor { get; set; }
    }
}