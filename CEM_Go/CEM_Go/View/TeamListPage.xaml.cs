using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using CEM_Go.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CEM_Go.View
{
    public partial class TeamListPage : ContentPage
    {
        //private ObservableCollection<Member> members { get; set; }

        public TeamListPage()
        {
            InitializeComponent();



            var assembly = typeof(TeamListPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("CEM_Go.DataSource.json");


            //*DataSource test
             ObservableCollection<Member> people = new ObservableCollection<Member>();

            people.Add(new Member { name = "Rob Finnerty" });
            people.Add(new Member { name = "Bill Wrestler" });
            people.Add(new Member { name = "Dr. Geri-Beth Hooper" });
            people.Add(new Member { name = "Dr. Keith Joyce-Purdy" });
            people.Add(new Member { name = "Sheri Spruce" });
            people.Add(new Member { name = "Burt Indybrick" });



            //Member[] members;
            //using (var reader = new StreamReader(stream))
            //{

            //    var json = reader.ReadToEnd();
            //    var rootobject = JsonConvert.DeserializeObject<Rootobject>(json);

            //    members = rootobject.members;
            //}



            //var listView = new ListView
            //{
            //    ItemsSource = people,					// people est un tableau
            //    ItemTemplate = new DataTemplate(() =>
            //    {
            //        var textCell = new TextCell();
            //        textCell.SetBinding(TextCell.TextProperty, "name");     // username est un attribut d'objet person
            //        //textCell.SetBinding(TextCell.DetailProperty, "qualification");
            //        return textCell;
            //    }),
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    SeparatorVisibility = SeparatorVisibility.None
            //};

            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    Children =
            //    {
            //        listView
            //    }
            //};
            //Title = "Personal Organiser";

            listView.ItemsSource = people;
        }
    }
}
