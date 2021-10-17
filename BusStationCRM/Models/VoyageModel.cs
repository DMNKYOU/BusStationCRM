﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using BusStationCRM.BLL.Enums;

namespace BusStationCRM.Models
{
    public class VoyageModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        [Display(Name = "Departure time")]
        public DateTime DepartureInfo { get; set; }

        [Display(Name = "Arrival time")]
        public DateTime ArrivalInfo { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true)]///////////////ADD ATTR
        public DateTime TravelTime { get; set; }

        [Display(Name = "Arrival seats")]
        public int NumberSeats { get; set; }

        [Display(Name = "Ticket price")]
        public double TicketCost { get; set; }

        public TypeTransport Type { get; set; }

        [Display(Name = "Departure stop")]
        [ForeignKey("BusStopDeparture")]
        public int BusStopDepartureId { get; set; }
        public BusStopModel BusStopDeparture { get; set; }

        [Display(Name = "Arrival stop")]
        [ForeignKey("BusStopArrival")]
        public int BusStopArrivalId { get; set; }
        public BusStopModel BusStopArrival { get; set; }

        public ICollection<BusStopModel> BusStops { get; set; }
        public ICollection<OrderModel> Orders { get; set; }
    }
}