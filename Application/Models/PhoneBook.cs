using System.ComponentModel.DataAnnotations;
using lang = MultiLanguage.Models.PhoneBook;
namespace Application.Models
{
    public class PhoneBook
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [StringLength(10, ErrorMessageResourceName = "StringMax", ErrorMessageResourceType = typeof(lang))]
        [Display(Name = "姓名", ResourceType = typeof(lang))]
        public string Name { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        [Display(Name="電話號碼", ResourceType = typeof(lang))]
        public string Numbers { get; set; }
    }
}
