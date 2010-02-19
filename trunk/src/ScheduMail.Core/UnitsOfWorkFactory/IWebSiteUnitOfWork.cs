﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScheduMail.Core.Domain;

namespace ScheduMail.Core.UnitsOfWorkFactory
{
    /// <summary>
    /// Web Site Unit of Work interface
    /// </summary>
    public interface IWebSiteUnitOfWork
    {
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <value>The Web site list.</value>
        List<WebSite> List { get; }

        /// <summary>
        /// Saves the specified web site.
        /// </summary>
        /// <param name="webSite">The web site.</param>
        /// <returns>Changed Web site instance.</returns>
        ScheduMail.Core.Domain.WebSite Save(WebSite webSite);

        /// <summary>
        /// Gets the by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Web Site instance.</returns>
        ScheduMail.Core.Domain.WebSite GetById(long id);

        /// <summary>
        /// Deletes the specified web site.
        /// </summary>
        /// <param name="webSite">The web site.</param>
        void Delete(WebSite webSite);
    }
}
