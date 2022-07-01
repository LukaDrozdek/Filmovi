﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filmovi.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SingUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string Name { get; set; }
    }
}