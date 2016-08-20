﻿using System.Web.Mvc;
using FluentValidation.Attributes;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;
using Nop.Web.Validators.Common;

namespace Nop.Web.Models.Common
{
    [Validator(typeof(ContactUsValidator))]
    public partial class ContactUsModel : BaseNopModel
    {
        [AllowHtml]
        [NopResourceDisplayName("ContactUs.Email")]
        public string Email { get; set; }

        [AllowHtml]
        [NopResourceDisplayName("ContactUs.Enquiry")]
        public string Enquiry { get; set; }

        [AllowHtml]
        [NopResourceDisplayName("ContactUs.FullName")]
        public string FullName { get; set; }

        [AllowHtml]
        [NopResourceDisplayName("ContactUs.BusinessName")]
        public string BusinessName { get; set; }

        [AllowHtml]
        [NopResourceDisplayName("ContactUs.Department")]
        public string Department { get; set; }

        [AllowHtml]
        [NopResourceDisplayName("ContactUs.Phone")]
        public string Phone { get; set; }

        [AllowHtml]
        [NopResourceDisplayName("ContactUs.Mobile")]
        public string Mobile { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}