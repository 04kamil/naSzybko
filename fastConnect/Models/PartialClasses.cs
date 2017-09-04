using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static fastConnect.Models.MetaData;

namespace fastConnect.Models
{
    public class PartialClasses

    {
        [MetadataType(typeof(TableMetadata))]
        public partial class Table
        {
        }
    }
}