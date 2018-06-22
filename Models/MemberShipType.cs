﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.DataHandler.Encoder;

namespace MovieWebApp.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }

        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }

        public enum MemberShipTypeEnum : byte
        {
            Unknow = 0,
            PassAsYouGo = 1,
            Monthly,
            Quaterly,
            Yearly
        }
    }
}