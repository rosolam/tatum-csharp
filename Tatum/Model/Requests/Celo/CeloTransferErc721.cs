﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tatum.Model;
using Tatum.Model.Requests;
using System.ComponentModel.DataAnnotations;

namespace Tatum.Model.Requests
{
    public class CeloTransferErc721 : TransferErc721
    {
        [Required]

        public Currency feecurrency { get; set; }
    }
}