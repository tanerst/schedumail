﻿/***************************************************************************************************
// -- Generated by AlteraxGen 17/02/2010 22:12:12
// Version 1.0
***************************************************************************************************/

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScheduMail.Core.Domain
{
    /// <summary>
    /// Web site Details
    /// </summary>
    [Serializable]
    public class WebSite : BaseEntity
    {
        /// <summary>
        /// Site name (Url to identify site)
        /// </summary>
        private string siteName;

        /// <summary>
        /// Header and Footer template for web site that (included in every email)
        /// </summary>
        private string template;

        /// <summary>
        /// Gets or sets the name of the site.
        /// </summary>
        /// <value>The name of the site.</value>
        [StringLength(50), Required(ErrorMessage = "Site Name is required")]
        [DisplayName("Site Name")]
        public string SiteName
        {
            get
            {
                return this.siteName;
            }

            set
            {
                this.siteName = value;
            }
        }

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        /// <value>The template.</value>        
        [Required(ErrorMessage = "Template is Required")]
        public string Template
        {
            get
            {
                return this.template;
            }

            set
            {
                this.template = value;
            }
        }
    }
}
