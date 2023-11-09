using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLibrary
{
    public class DataModels
    {
        
        
        public int Id { get; set; }

        [Display(Name = " وضعیت پشتیبانی:")]
        public bool IsActive { get; set; }

        [Display(Name ="نام آزمایشگاه:")]
        [Required(ErrorMessage ="نام آزمایشگاه الزامی است")]
        public string fullName { get; set; }

        [Required(ErrorMessage = "نام پزشک الزامی است")]
        [Display(Name ="نام پزشک:")]
        public string DrName { get; set; }

        [Display(Name = "موبایل :")]
        public string DrMobile { get; set; }

       
        [Display(Name ="مسئول رابط")]
        public string MasoolAz { get; set; }

        [Display(Name ="موبایل مسئول")]
        public string MasoolTel { get; set; }

        [Display(Name = " آدرس")]
        public string Address { get; set; }

        [Required(ErrorMessage = "تلفن الزامی است")]
        [Display(Name ="تلفن:")]
        public string Phone { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "پایان پشتیبانی")]
        public string EndOfSupport { get; set; }

        [Display(Name ="آخرین مبلغ پشتیبانی")]
        public string LastMoney { get; set; }

        [Display(Name = " جوابدهی آنلاین:")]
        public bool ResponseOnline { get; set; }

        [Display(Name = " مدیر آنلاین:")]
        public bool LabManagerOnline { get; set; }

        [Display(Name = "مدیا:")]
        public bool Media { get; set; }

        [Display(Name = "مدیاQR")]
        public bool MediaQR { get; set; }

        [Display(Name = "اس ام اس")]
        public bool Sms { get; set; }

        [Display(Name = "کنترل کیفی")]
        public bool Qc { get; set; }

        [Display(Name = "انبارداری")]
        public bool Storage { get; set; }

        [Display(Name = " بکاپ سینک:")]
        public bool BackupSync { get; set; }
    }
}
