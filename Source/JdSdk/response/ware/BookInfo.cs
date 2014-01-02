﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class BookInfo : JdObject
    {
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        [JsonProperty("first_category")]
        public Nullable<Int32> FirstCategory
        {
            get;
            set;
        }

        [JsonProperty("isbn")]
        public String Isbn
        {
            get;
            set;
        }

        [JsonProperty("issn")]
        public String Issn
        {
            get;
            set;
        }

        [JsonProperty("book_name")]
        public String BookName
        {
            get;
            set;
        }

        [JsonProperty("foreign_book_name")]
        public String ForeignBookName
        {
            get;
            set;
        }

        [JsonProperty("language")]
        public String Language
        {
            get;
            set;
        }

        [JsonProperty("author")]
        public String Author
        {
            get;
            set;
        }

        [JsonProperty("editer")]
        public String Editer
        {
            get;
            set;
        }

        [JsonProperty("proofreader")]
        public String Proofreader
        {
            get;
            set;
        }

        [JsonProperty("remarker")]
        public String Remarker
        {
            get;
            set;
        }

        [JsonProperty("transfer")]
        public String Transfer
        {
            get;
            set;
        }

        [JsonProperty("drawer")]
        public String Drawer
        {
            get;
            set;
        }

        [JsonProperty("publishers")]
        public String Publishers
        {
            get;
            set;
        }

        [JsonProperty("publish_no")]
        public String PublishNo
        {
            get;
            set;
        }

        [JsonProperty("series")]
        public String Series
        {
            get;
            set;
        }

        [JsonProperty("brand")]
        public String Brand
        {
            get;
            set;
        }

        [JsonProperty("format")]
        public String Format
        {
            get;
            set;
        }

        [JsonProperty("packages")]
        public String Packages
        {
            get;
            set;
        }

        [JsonProperty("pages")]
        public String Pages
        {
            get;
            set;
        }

        [JsonProperty("batch_no")]
        public String BatchNo
        {
            get;
            set;
        }

        [JsonProperty("publish_time")]
        public String PublishTime
        {
            get;
            set;
        }

        [JsonProperty("print_no")]
        public Nullable<Int32> PrintNo
        {
            get;
            set;
        }

        [JsonProperty("print_time")]
        public String PrintTime
        {
            get;
            set;
        }

        [JsonProperty("size_and_height")]
        public String SizeAndHeight
        {
            get;
            set;
        }

        [JsonProperty("china_catalog")]
        public String ChinaCatalog
        {
            get;
            set;
        }

        [JsonProperty("sheet")]
        public String Sheet
        {
            get;
            set;
        }

        [JsonProperty("papers")]
        public String Papers
        {
            get;
            set;
        }

        [JsonProperty("attachment")]
        public String Attachment
        {
            get;
            set;
        }

        [JsonProperty("attachment_num")]
        public Nullable<Int32> AttachmentNum
        {
            get;
            set;
        }

        [JsonProperty("pack_num")]
        public Nullable<Int32> PackNum
        {
            get;
            set;
        }

        [JsonProperty("letters")]
        public Nullable<Int32> Letters
        {
            get;
            set;
        }

        [JsonProperty("bar_code")]
        public String BarCode
        {
            get;
            set;
        }

        [JsonProperty("keywords")]
        public String Keywords
        {
            get;
            set;
        }

        [JsonProperty("pick_state")]
        public String PickState
        {
            get;
            set;
        }

        [JsonProperty("compile")]
        public String Compile
        {
            get;
            set;
        }

        [JsonProperty("photography")]
        public String Photography
        {
            get;
            set;
        }

        [JsonProperty("dictation")]
        public String Dictation
        {
            get;
            set;
        }

        [JsonProperty("read")]
        public String Read
        {
            get;
            set;
        }

        [JsonProperty("finishing")]
        public String Finishing
        {
            get;
            set;
        }

        [JsonProperty("write")]
        public String Write
        {
            get;
            set;
        }

    }

}
