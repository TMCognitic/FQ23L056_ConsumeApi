﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FQ23L056_ConsumeApi.Bll.Entities
{
    public class UserTask
    {
        public int Id { get; internal set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public UserTask(string title)
        {
            Title = title;
        }
        internal UserTask(int id, string title, bool done)
            : this (title)
        {
            Id = id;
            Done = done;
        }
    }
}
