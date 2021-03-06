﻿using Moz.Bus.Models.Localization;
using Moz.Bus.Models.Members;

namespace Moz.Core
{
    public interface IWorkContext
    {
        SimpleMember CurrentMember { get; }
        bool IsAdmin { get; }
        Language WorkingLanguage { get; }
    }
}