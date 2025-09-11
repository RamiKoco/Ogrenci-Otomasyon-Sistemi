
namespace AbcYazilim.Blazor.Core.Components.Dev.Resources;
public class StatusObject
{
    public int Id { get; set; }
    public int? GroupId { get; set; }
    public string StatusCaption { get; set; }
    public bool IsGroup { get; set; }
    public System.Drawing.Color StatusColor { get; set; }
    public string CssClass { get; set; }
    public string MyCustomField { get; set; } // A custom field
}
