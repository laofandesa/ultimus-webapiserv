using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSenDocumentTxDocAtt
    {
        public int Id { get; set; }
        public string AttFileName { get; set; }
        public int? AttFileId { get; set; }
        public int? TxDocId { get; set; }
    }
}
