using System;
using System.ComponentModel.DataAnnotations;

namespace WCFSOAPService.Model
{
    public class Distributor
    {
        [Key]
        public Guid BODS_Id { get; set; }

        public string BODS_FullName { get; set; }

        public byte BODS_Status { get; set; }
    }
}