using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.DataModels.APIModels
{
    [XmlRoot(ElementName = "route")]
    class MapQuestRequestModel
    {
        [XmlArray(ElementName = "locations")]
        [XmlArrayItem(ElementName = "location")]
        public List<string> locations { get; set; }

        [XmlElement(ElementName = "options")]
        public MapQuestOptionsModel options { get; set; }
    }
}