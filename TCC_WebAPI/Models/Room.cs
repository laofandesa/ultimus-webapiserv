using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class Room
    {
        public string RoomCode { get; set; }
        public string RoomName { get; set; }
        public string Location { get; set; }
        public string RoomDesc { get; set; }
        public int Capacity { get; set; }
        public string Photo { get; set; }
        public string Layout { get; set; }
        public int IsApproval { get; set; }
        public int State { get; set; }
        public int IsEffective { get; set; }
        public int Price { get; set; }
        public string Tst { get; set; }
        public long Id { get; set; }
    }
}
