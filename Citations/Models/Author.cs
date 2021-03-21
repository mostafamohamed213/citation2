using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Citations.Models
{
    public partial class Author
    {
        public Author()
        {
            ArticleAuthores = new HashSet<ArticleAuthore>();
            AuthorResearchFields = new HashSet<AuthorResearchField>();
            AuthorsPositionInstitutions = new HashSet<AuthorsPositionInstitution>();
            BookAuthores = new HashSet<BookAuthore>();
            ConferenceProceedingsAuthors = new HashSet<ConferenceProceedingsAuthor>();
        }

        public int Authorid { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب", AllowEmptyStrings = false), Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "الصورة")]
        public string ScannedAuthorimage { get; set; }
        [Display(Name = "الحالة")]
        public string AuthorBio { get; set; }
        [Display(Name = "معامل H"), Required(ErrorMessage = "هذا الحقل مطلوب", AllowEmptyStrings = false)]
        public int PointerH { get; set; }
        [Display(Name = "نشط")]
        public bool Active { get; set; }
[Display(Name = "الموقع")]
        public string Website { get; set; }
        [Display(Name = "فيس بوك")]
        public string Facebook { get; set; }
        [Display(Name = "تويتر")]
        public string Twitter { get; set; }
        [ Display(Name = "رقم التليفون"),StringLength(maximumLength: 15, ErrorMessage ="رقم الهاتف يجب ان يكون بين 9 الى 15 رقم",MinimumLength  =9), Remote("AutherMobileExistsremote", "RemoteValidation", AdditionalFields = "Authorid")]
        public string Mobile { get; set; }
        [ Display(Name = "العنوان")]
        public string Address { get; set; }
        [ Display(Name = "الايميل"), Remote("AutheremailExistsremote", "RemoteValidation", AdditionalFields = "Authorid") ,DataType(DataType.EmailAddress,ErrorMessage ="الصيغة غير صحيحة") ,Required(ErrorMessage = "هذا الحقل مطلوب", AllowEmptyStrings = false),]
        public string Email { get; set; }
        [Display(Name = "الجنسية")]
        public int? Nationality { get; set; }


        public virtual Country NationalityNavigation { get; set; }
        public virtual ICollection<ArticleAuthore> ArticleAuthores { get; set; }
        [Display(Name = "مجالات البحث")]
        public virtual ICollection<AuthorResearchField> AuthorResearchFields { get; set; }
        [Display(Name = "الموقع الوظيفي")]
        public virtual ICollection<AuthorsPositionInstitution> AuthorsPositionInstitutions { get; set; }
        public virtual ICollection<BookAuthore> BookAuthores { get; set; }
        public virtual ICollection<ConferenceProceedingsAuthor> ConferenceProceedingsAuthors { get; set; }
    }
}
