﻿using System;
using System.Collections.Generic;

namespace Desktop.Models;

public partial class Role
{
    public int IdRole { get; set; }

    public string NameRole { get; set; } = null!;

    public virtual ICollection<Juri> Juris { get; set; } = new List<Juri>();

    public virtual ICollection<Moder> Moders { get; set; } = new List<Moder>();

    public virtual ICollection<Organizer> Organizers { get; set; } = new List<Organizer>();

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
