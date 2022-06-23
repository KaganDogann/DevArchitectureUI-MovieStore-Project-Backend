﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class MovieActor:IEntity
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int MovieId { get; set; }
    }
}
