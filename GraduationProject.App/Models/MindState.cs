using System;
using System.Collections.Generic;

namespace GraduationProject.App.Models;

public partial class MindState
{
    public int MindStateId { get; set; }

    public int UserId { get; set; }

    public int LectureId { get; set; }

    public string MeetinxgId { get; set; } = null!;

    public string State { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
