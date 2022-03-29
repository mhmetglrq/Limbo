using Limbo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Entities.Dtos
{
    public class CommentAddDto
    {
        [DisplayName("Cümle")]
        [Required(ErrorMessage ="{0} başlık alanı boş geçilmemelidir")]
        [MaxLength(100,ErrorMessage ="{0} alanı {1} karakterden fazla olmamalıdır")]
        [MinLength(5,ErrorMessage ="{0} alanı {1} karakterden az olmamalıdır")]
        public string Text { get; set; }
        [Required(ErrorMessage ="{0} alanı boş geçilmemelidir")]
        public int Value { get; set; }

        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} başlık alanı boş geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
