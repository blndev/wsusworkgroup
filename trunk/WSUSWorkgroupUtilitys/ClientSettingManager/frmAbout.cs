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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();

            //  Initialisieren Sie AboutBox, um die Produktinformationen aus den Assemblyinformationen anzuzeigen.
            //  Ändern Sie die Einstellungen für Assemblyinformationen für Ihre Anwendung durch eine der folgenden Vorgehensweisen:
            //  - Projekt->Eigenschaften->Anwendung->Assemblyinformationen
            //  - AssemblyInfo.cs
            this.Text = String.Format("Informations about {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = License.Text;
        }

        #region Assemblyattributaccessoren

        public string AssemblyTitle
        {
            get
            {
                // Alle Title-Attribute in dieser Assembly abrufen
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // Wenn mindestens ein Title-Attribut vorhanden ist
                if (attributes.Length > 0)
                {
                    // Erstes auswählen
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // Zurückgeben, wenn es keine leere Zeichenfolge ist
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // Wenn kein Title-Attribut vorhanden oder das Title-Attribut eine leere Zeichenfolge war, den EXE-Namen zurückgeben
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // Alle Description-Attribute in dieser Assembly abrufen
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // Eine leere Zeichenfolge zurückgeben, wenn keine Description-Attribute vorhanden sind
                if (attributes.Length == 0)
                    return "";
                // Den Wert des Description-Attributs zurückgeben, wenn eines vorhanden ist
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // Alle Product-Attribute in dieser Assembly abrufen
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // Eine leere Zeichenfolge zurückgeben, wenn keine Product-Attribute vorhanden sind
                if (attributes.Length == 0)
                    return "";
                // Den Wert des Product-Attributs zurückgeben, wenn eines vorhanden ist
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // Alle Copyright-Attribute in dieser Assembly abrufen
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // Eine leere Zeichenfolge zurückgeben, wenn keine Copyright-Attribute vorhanden sind
                if (attributes.Length == 0)
                    return "";
                // Den Wert des Copyright-Attributs zurückgeben, wenn eines vorhanden ist
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // Alle Company-Attribute in dieser Assembly abrufen
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // Eine leere Zeichenfolge zurückgeben, wenn keine Company-Attribute vorhanden sind
                if (attributes.Length == 0)
                    return "";
                // Den Wert des Company-Attributs zurückgeben, wenn eines vorhanden ist
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
