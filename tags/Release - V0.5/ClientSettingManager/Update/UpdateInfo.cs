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

namespace Codeplex.DBedarf.Update
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, IncludeInSchema = false)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "history", IsNullable = false)]
    public class UpdateInfo
    {

        public static UpdateInfo GetInfo(string url)
        {
            ////TODO: WebDown + Auswertung
            UpdateInfo retVal = new UpdateInfo();
            //try
            //{

            //    string xml=System.IO.Net.HTTPRequest
            //    System.IO.StringReader ms = new System.IO.StringReader(xml);
            //    System.Xml.XmlReader reader = new System.Xml.XmlTextReader(ms);

            //    System.Xml.Serialization.XmlSerializer ser =
            //    new System.Xml.Serialization.XmlSerializer(typeof(UpdateInfo));
            //    retVal = (UpdateInfo)ser.Deserialize(reader);
            //    reader.Close();
            //    ms.Close();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("error while receiving udate informations" + ex.Message, ex);
            //}
            return retVal;
        }


        #region InfoMembers

        public UpdateInfo()
        {
            _updateURL="";
            _timestamp="";
            _currentVersion="";
            _liste = new List<UpdateChangeInfo>();
        }

        string _currentVersion;
        [System.Xml.Serialization.XmlAttributeAttribute("current")]
        public string CurrentVersion
        {
            get
            {
                return _currentVersion;
            }
            set
            {
                _currentVersion = value;
            }
        }

        string _timestamp;
        [System.Xml.Serialization.XmlAttributeAttribute("timestamp")]
        public string LastUpdateTimestamp
        {
            get
            {
                return _timestamp;
            }
            set
            {
                _timestamp = value;
            }
        }

        string _updateURL;
        [System.Xml.Serialization.XmlAttributeAttribute("updateURL")]
        public string updateURL
        {
            get
            {
                return _updateURL;
            }
            set
            {
                _updateURL = value;
            }
        }

        List<UpdateChangeInfo> _liste;
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "changes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("changeinfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public UpdateChangeInfo[] ChangeInfosArr
        {
            get
            {
                return _liste.ToArray();
            }
            set
            {
                _liste = new List<UpdateChangeInfo>(value);
            }
        }

        //Für den einfacheren Memberzugriff mit .Add etc
        [System.Xml.Serialization.XmlIgnore()]
        public List<UpdateChangeInfo> ChangeInfos
        {
            get
            {
                return _liste;
            }
        }
        #endregion InfoMembers

    }//end UpdateInfo
        
    #region UpdateChanges

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, IncludeInSchema = false)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "changeinfo", IsNullable = false)]
    public class UpdateChangeInfo
    {

        public UpdateChangeInfo()
        {
            _version = "";
            _timestamp = "";
            _message = "";
        }

        string _version;
        [System.Xml.Serialization.XmlAttributeAttribute("version")]
        public string Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }

        string _timestamp;
        [System.Xml.Serialization.XmlAttributeAttribute("timestamp")]
        public string LastUpdateTimestamp
        {
            get
            {
                return _timestamp;
            }
            set
            {
                _timestamp = value;
            }
        }

        string _message;
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }
    }
    #endregion 

}
