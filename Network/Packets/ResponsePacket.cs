﻿#region Licence - LGPLv3

// ***********************************************************************
// Assembly         : Network
// Author           : Thomas Christof
// Created          : 02-10-2016
//
// Last Modified By : Thomas Christof
// Last Modified On : 10-10-2015
// ***********************************************************************
// <copyright>
// Company: Indie-Dev
// Thomas Christof (c) 2018
// </copyright>
// <License>
// GNU LESSER GENERAL PUBLIC LICENSE
// </License>
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ***********************************************************************

#endregion Licence - LGPLv3

namespace Network.Packets
{
    /// <summary>
    /// Represents a response to a <see cref="RequestPacket"/>.
    /// </summary>
    /// <remarks>
    /// For the packet to be handled correctly, the handled
    /// <see cref="RequestPacket"/> must be given in the constructor.
    /// </remarks>
    public class ResponsePacket : Packet
    {
        #region Constructors

        /// <summary>
        /// Default constructor for a response packet.
        /// </summary>
        /// <param name="packet">
        /// The <see cref="RequestPacket"/> that is being handled.
        /// </param>
        public ResponsePacket(RequestPacket packet)
        {
            ID = packet.ID;
        }

        #endregion Constructors
    }
}