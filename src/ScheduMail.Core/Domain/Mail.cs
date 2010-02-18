﻿/***************************************************************************************************
// -- Generated by AlteraxGen 17/02/2010 22:12:12
// Version 1.0
***************************************************************************************************/

using System;

namespace ScheduMail.Core.Domain
{
    /// <summary>
    /// Mail template definition. Used to define Email 
    /// template for forwarding on to recipients.
    /// </summary>
    [Serializable]
    public class Mail : BaseEntity
    {
        /// <summary>
        /// Foreign key for Web Site
        /// </summary>
        private int webSiteId;

        /// <summary>
        /// Subject for email
        /// </summary>
        private string subject;

        /// <summary>
        /// EMail content
        /// </summary>
        private string eMailContent;

        /// <summary>
        /// User name (used for logging onto remote system get to list if recipients)
        /// </summary>
        private string userName;

        /// <summary>
        /// Password (used for logging onto remote system get to list if recipients)
        /// </summary>
        private string password;

        /// <summary>
        /// Gets or sets the web site id.
        /// </summary>
        /// <value>The web site id.</value>
        public int WebSiteId
        {
            get
            {
                return this.webSiteId;
            }
            set
            {
                this.webSiteId = value;
            }
        }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }

        /// <summary>
        /// Gets or sets the content of the E mail.
        /// </summary>
        /// <value>The content of the E mail.</value>
        public string EMailContent
        {
            get
            {
                return this.eMailContent;
            }
            set
            {
                this.eMailContent = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
    }
}
