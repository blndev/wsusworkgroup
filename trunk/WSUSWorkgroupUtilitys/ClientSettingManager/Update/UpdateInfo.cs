// Copyright (C) 2009 Daniel Bedarf
//
// For further information visit: http://wsusworkgroup.codeplex.com/
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager.Update
{
    /// <summary>
    /// Informations about the available Update
    /// </summary>
    struct UpdateInfo
    {
        public void Clear()
        {
            Titel = "";
            Message = "";
            URL = "";
            Version = new Version();
            HTMLHistory = "";
        }

        /// <summary>
        /// The UpdateTitle
        /// </summary>
        public string Titel;

        /// <summary>
        /// the Update Messageblock
        /// </summary>
        public string Message;

        /// <summary>
        /// A URL for more Information
        /// </summary>
        public string URL;

        /// <summary>
        /// the new VersionID (not the ApplicationVersion)
        /// </summary>
        public System.Version Version;

        /// <summary>
        /// a HTML Text with History Informations
        /// </summary>
        public string HTMLHistory;
    }
}
