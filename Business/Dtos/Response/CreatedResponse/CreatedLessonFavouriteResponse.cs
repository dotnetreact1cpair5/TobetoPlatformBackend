﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedLessonFavouriteResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int LessonId { get; set; }
    }

}
