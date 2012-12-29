﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CommonJobs.Domain
{
    public class SimpleNote : IEvent
    {
        [Display(Name = "Fecha Real")]
        [DataType(DataType.DateTime)]
        public DateTime RealDate { get; set; }

        [Display(Name = "Fecha registrada")]
        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "Nota")]
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        public string EventType { get; set; }
    }
}
