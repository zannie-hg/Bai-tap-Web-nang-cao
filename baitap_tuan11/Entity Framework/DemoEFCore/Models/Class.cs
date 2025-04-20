using System;
using System.Collections.Generic;

namespace DemoEFCore.Models;

public partial class Class
{
    public string ClassId { get; set; } = null!;

    public string? ClassName { get; set; }

    public int? Year { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
