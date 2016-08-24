using System.IO;
using System.Reflection;
using CEM_Go.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CEM_Go.View
{
    public class ReferenceList : ContentPage
    {
        public ReferenceList()
        {
            var assembly = typeof(ReferenceList).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("CEM_Go.Data.json");

            Reference[] references;
            using (var reader = new StreamReader(stream))
            {

                var json = reader.ReadToEnd();
                var rootobject2 = JsonConvert.DeserializeObject<AllReferences>(json);

                references = rootobject2.references;
            }

            var listView = new ListView
            {
                ItemsSource = references,
                ItemTemplate = new DataTemplate(() =>
                {
                    var textCell = new TextCell();
                    textCell.SetBinding(TextCell.TextProperty, "project");
                    // textCell.SetBinding(TextCell.DetailProperty, "name");
                    return textCell;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    listView
                }
            };
            Title = "Personal Organiser";
        }
    }
}
