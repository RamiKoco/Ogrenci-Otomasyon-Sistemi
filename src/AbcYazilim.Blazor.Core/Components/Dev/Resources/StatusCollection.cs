using System.Collections.Generic;
using System;
using System.Linq;
namespace AbcYazilim.Blazor.Core.Components.Dev.Resources;
public static class StatusCollection
{
    public static List<StatusObject> GetResourcesForGrouping()
    {
        return GetStatuses().Take(3).ToList();
    }
    public static List<StatusObject> GetStatuses()
    {
        DateTime date = DateTime.Today;
        var dataSource = new List<StatusObject>() {
            new StatusObject() {
                Id = 1,
                StatusCaption = "Nakit Tahsilat",GroupId=100,
                StatusColor = System.Drawing.Color.SkyBlue,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status1-style",
                MyCustomField = "Custom text for the 'Resolved' status",
            },
            new StatusObject() {
                Id = 2,
                StatusCaption = "Kredi Kartı Tahsilat",GroupId=100,
                StatusColor = System.Drawing.Color.Blue,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                MyCustomField = "Custom text for the 'In process' status",
            },
              new StatusObject() {
                Id = 3,
                StatusCaption = "Çek Tahsilat",GroupId=100,
                StatusColor = System.Drawing.Color.LightGreen,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                MyCustomField = "Custom text for the 'In process' status",
            },
                  new StatusObject() {
                Id = 4,
                StatusCaption = "Kredi Kartı Ödeme",GroupId=101,
                StatusColor = System.Drawing.Color.DarkGreen,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                //
                MyCustomField = "Custom text for the 'In process' status",
            },
                  new StatusObject() {
                Id = 5,
                StatusCaption = "Nakit Ödeme",GroupId=101,
                StatusColor = System.Drawing.Color.Indigo,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                //
                MyCustomField = "Custom text for the 'In process' status",
            },
                   new StatusObject() {
                Id = 6,
                StatusCaption = "Çek Ödeme",GroupId=101,
                StatusColor = System.Drawing.Color.Orange,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                //
                MyCustomField = "Custom text for the 'In process' status",
            },
                  new StatusObject() {
                Id = 7,
                StatusCaption = "Fazla Ödeme",GroupId=102,
                StatusColor = System.Drawing.Color.Yellow,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                //
                MyCustomField = "Custom text for the 'In process' status",
            },
                    new StatusObject() {
                Id = 8,
                StatusCaption = "Gelecek Havale",GroupId=102,
                StatusColor = System.Drawing.Color.SpringGreen,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                //
                MyCustomField = "Custom text for the 'In process' status",
            },
                     new StatusObject() {
                Id = 9,
                StatusCaption = "Gönderilecek Havale",GroupId=102,
                StatusColor = System.Drawing.Color.SteelBlue,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                //
                MyCustomField = "Custom text for the 'In process' status",
            },
                      new StatusObject() {
                Id = 10,
                StatusCaption = "Ödünç Alınan Para",GroupId=100,
                StatusColor = System.Drawing.Color.Fuchsia,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                //
                MyCustomField = "Custom text for the 'In process' status",
            },
                      
                new StatusObject() {
                Id = 11,
                StatusCaption = "Takip",GroupId=101,
                StatusColor = System.Drawing.Color.Brown,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                MyCustomField = "Custom text for the 'In process' status",
            },
                         new StatusObject() {
                Id = 12,
                StatusCaption = "Diğer",
                StatusColor = System.Drawing.Color.Red,
                // Uncomment the line below and comment the line above to specify other style options.
                //CssClass = "status2-style",
                //
                MyCustomField = "Custom text for the 'In process' status",
            }
        };
        return dataSource;
    }

    public static List<StatusObject> GetStatusGroups()
    {
        return new List<StatusObject>() {
                new StatusObject() { Id=100, StatusCaption="Sales and Marketing", IsGroup=true },
                new StatusObject() { Id=101, StatusCaption="Engineering", IsGroup=true }
            };
    }
}

