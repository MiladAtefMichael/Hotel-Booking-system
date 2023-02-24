﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingDAL.Models
{
    public partial class resident_room
    {
        [Key]
        public int reservation_ID { get; set; }
        public long? resident_nationalID { get; set; }
        public int? room_id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? start_book_date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? end_book_date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? checkout_date { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? room_total_price { get; set; }
        public bool? canceled { get; set; } = false;
        public bool? is_active { get; set; } = false;
        [JsonIgnore]
        [ForeignKey("resident_nationalID")]
        [InverseProperty("resident_rooms")]
        public virtual resident resident { get; set; }
        [JsonIgnore]
        [ForeignKey("room_id")]
        [InverseProperty("resident_rooms")]
        public virtual room room { get; set; }
    }
}