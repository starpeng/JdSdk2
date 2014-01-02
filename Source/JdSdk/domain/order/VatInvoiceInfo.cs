﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class VatInvoiceInfo : JdObject
    {
        [JsonProperty("taxpayer_ident")]
        public String TaxpayerIdent
        {
            get;
            set;
        }

        [JsonProperty("registered_address")]
        public String RegisteredAddress
        {
            get;
            set;
        }

        [JsonProperty("registered_phone")]
        public String RegisteredPhone
        {
            get;
            set;
        }

        [JsonProperty("deposit_bank")]
        public String DepositBank
        {
            get;
            set;
        }

        [JsonProperty("bank_account")]
        public String BankAccount
        {
            get;
            set;
        }

    }

}
