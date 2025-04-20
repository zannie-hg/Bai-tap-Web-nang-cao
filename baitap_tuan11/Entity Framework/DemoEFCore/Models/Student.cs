using System;
using System.Collections.Generic;

namespace DemoEFCore.Models;

public partial class Student
{
    public string StudentId { get; set; } = null!;

    public string? Name { get; set; }

    public string? ClassId { get; set; }

    public virtual Class? Class { get; set; }
}
