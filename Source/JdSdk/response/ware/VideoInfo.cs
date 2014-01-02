﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class VideoInfo : JdObject
    {
        [JsonProperty("sid")]
        public String Sid
        {
            get;
            set;
        }

        [JsonProperty("aka")]
        public String Aka
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

        [JsonProperty("brand")]
        public String Brand
        {
            get;
            set;
        }

        [JsonProperty("foreignname")]
        public String Foreignname
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

        [JsonProperty("barcode")]
        public String Barcode
        {
            get;
            set;
        }

        [JsonProperty("mvd_wxjz")]
        public String MvdWxjz
        {
            get;
            set;
        }

        [JsonProperty("mvd_gqyz")]
        public String MvdGqyz
        {
            get;
            set;
        }

        [JsonProperty("mvd_wyjz")]
        public String MvdWyjz
        {
            get;
            set;
        }

        [JsonProperty("isrc")]
        public String Isrc
        {
            get;
            set;
        }

        [JsonProperty("mvd_dcz")]
        public String MvdDcz
        {
            get;
            set;
        }

        [JsonProperty("mvd_xcyg")]
        public String MvdXcyg
        {
            get;
            set;
        }

        [JsonProperty("press")]
        public String Press
        {
            get;
            set;
        }

        [JsonProperty("publishing_company")]
        public String PublishingCompany
        {
            get;
            set;
        }

        [JsonProperty("production_company")]
        public String ProductionCompany
        {
            get;
            set;
        }

        [JsonProperty("copyright")]
        public String Copyright
        {
            get;
            set;
        }

        [JsonProperty("actor")]
        public String Actor
        {
            get;
            set;
        }

        [JsonProperty("director")]
        public String Director
        {
            get;
            set;
        }

        [JsonProperty("dub")]
        public String Dub
        {
            get;
            set;
        }

        [JsonProperty("voiceover")]
        public String Voiceover
        {
            get;
            set;
        }

        [JsonProperty("screenwriter")]
        public String Screenwriter
        {
            get;
            set;
        }

        [JsonProperty("producer")]
        public String Producer
        {
            get;
            set;
        }

        [JsonProperty("singer")]
        public String Singer
        {
            get;
            set;
        }

        [JsonProperty("performer")]
        public String Performer
        {
            get;
            set;
        }

        [JsonProperty("authors")]
        public String Authors
        {
            get;
            set;
        }

        [JsonProperty("compose")]
        public String Compose
        {
            get;
            set;
        }

        [JsonProperty("command")]
        public String Command
        {
            get;
            set;
        }

        [JsonProperty("orchestra")]
        public String Orchestra
        {
            get;
            set;
        }

        [JsonProperty("media")]
        public String Media
        {
            get;
            set;
        }

        [JsonProperty("soundtrack")]
        public Nullable<Int32> Soundtrack
        {
            get;
            set;
        }

        [JsonProperty("number_of_discs")]
        public Nullable<Int32> NumberOfDiscs
        {
            get;
            set;
        }

        [JsonProperty("episode")]
        public Nullable<Int32> Episode
        {
            get;
            set;
        }

        [JsonProperty("record_number")]
        public Nullable<Int32> RecordNumber
        {
            get;
            set;
        }

        [JsonProperty("publication_date")]
        public Nullable<DateTime> PublicationDate
        {
            get;
            set;
        }

        [JsonProperty("release_date")]
        public Nullable<DateTime> ReleaseDate
        {
            get;
            set;
        }

        [JsonProperty("accessories")]
        public String Accessories
        {
            get;
            set;
        }

        [JsonProperty("included_additional_item")]
        public Nullable<Int32> IncludedAdditionalItem
        {
            get;
            set;
        }

        [JsonProperty("set_the_number_of")]
        public Nullable<Int32> SetTheNumberOf
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

        [JsonProperty("color")]
        public String Color
        {
            get;
            set;
        }

        [JsonProperty("region")]
        public String Region
        {
            get;
            set;
        }

        [JsonProperty("length")]
        public String Length
        {
            get;
            set;
        }

        [JsonProperty("screen_ratio")]
        public String ScreenRatio
        {
            get;
            set;
        }

        [JsonProperty("audio_encoding_chinese")]
        public String AudioEncodingChinese
        {
            get;
            set;
        }

        [JsonProperty("quality_description")]
        public String QualityDescription
        {
            get;
            set;
        }

        [JsonProperty("dregion")]
        public String Dregion
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

        [JsonProperty("language_dubbed")]
        public String LanguageDubbed
        {
            get;
            set;
        }

        [JsonProperty("language_subtitled")]
        public String LanguageSubtitled
        {
            get;
            set;
        }

        [JsonProperty("version_language")]
        public String VersionLanguage
        {
            get;
            set;
        }

        [JsonProperty("language_pronunciation")]
        public String LanguagePronunciation
        {
            get;
            set;
        }

        [JsonProperty("menu_language")]
        public String MenuLanguage
        {
            get;
            set;
        }

        [JsonProperty("version")]
        public String Version
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public String Type
        {
            get;
            set;
        }

        [JsonProperty("platform")]
        public String Platform
        {
            get;
            set;
        }

        [JsonProperty("minimum_system_requirement_description")]
        public String MinimumSystemRequirementDescription
        {
            get;
            set;
        }

        [JsonProperty("recommended_system_description")]
        public String RecommendedSystemDescription
        {
            get;
            set;
        }

        [JsonProperty("online_play_description")]
        public String OnlinePlayDescription
        {
            get;
            set;
        }

        [JsonProperty("awards")]
        public String Awards
        {
            get;
            set;
        }

        [JsonProperty("type_keywords")]
        public String TypeKeywords
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

        [JsonProperty("readers")]
        public String Readers
        {
            get;
            set;
        }

        [JsonProperty("number_of_players")]
        public String NumberOfPlayers
        {
            get;
            set;
        }

        [JsonProperty("mfg_minimum")]
        public Nullable<Int32> MfgMinimum
        {
            get;
            set;
        }

        [JsonProperty("mfg_maximum")]
        public Nullable<Int32> MfgMaximum
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
