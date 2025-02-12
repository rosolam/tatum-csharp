﻿using System.Linq;
using System.Web;
using Tatum.Model;
using Tatum.Model.Requests;
using System.ComponentModel.DataAnnotations;

namespace Tatum.Model.Requests
{
    public class TransferFlow : FlowMnemonicOrPrivateKeyOrSignatureId
    {

        [Required]
        public string to { get; set; }

        [Required]
        public string amount { get; set; }

        [Required]
        public Currency currency { get; set; }

      

    }
}