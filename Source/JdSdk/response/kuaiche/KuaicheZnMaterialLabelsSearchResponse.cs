﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnMaterialLabelsSearchResponse : JdResponse
    {
        [JsonProperty("material_label_list")]
        public List<MaterialLableJO> MaterialLabelList
        {
            get;
            set;
        }

    }

}
