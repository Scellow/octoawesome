﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OctoAwesome.Entities
{
    /// <summary>
    /// Schnittstelle für Entitäten mit Körpermaßen.
    /// </summary>
    public interface IBody
    {
        /// <summary>
        /// Der Radius der Entity in Blocks.
        /// </summary>
        float Radius { get; set; }

        /// <summary>
        /// Die Körperhöhe der Entity in Blocks
        /// </summary>
        float Height { get; set; }
    }
}
