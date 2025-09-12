using System;
using Microsoft.AspNetCore.Components;

namespace OOS.Blazor.Core.Services;

public interface ICoreCommonService
{
    public Action HasChanged { get; set; }
    public ComponentBase ActiveEditComponent { get; set; }
}