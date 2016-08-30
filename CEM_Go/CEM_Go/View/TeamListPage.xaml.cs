using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using CEM_Go.Model;
using Xamarin.Forms;

namespace CEM_Go.View
{
    public partial class TeamListPage : ContentPage
    {
        //private ObservableCollection<Member> members { get; set; }

        public TeamListPage()
        {
            InitializeComponent();



           /* var assembly = typeof(TeamListPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("CEM_Go.DataSource.json");
            string ze;  
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                DependencyService.Get<ISaveAndLoad>().SaveText("Data.json", json);
                ze = DependencyService.Get<ISaveAndLoad>().LoadText("Data.json");
            }

                

            Label lbl = new Label {Text = ze};

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                   lbl
                }
            };*/

            //*DataSource test
            ObservableCollection<Member> people = new ObservableCollection<Member>();

          /*  people.Add(new Member { name = "Rob Finnerty", qualification = "Chef de projet", photo = "psyduck.png"});
            people.Add(new Member { name = "Bill Wrestler" , qualification = "Cheerleader", photo = "psyduck.png" });
            people.Add(new Member { name = "Dr. Geri-Beth Hooper", qualification = "Cheerleader", photo = "psyduck.png" });
            people.Add(new Member { name = "Dr. Keith Joyce-Purdy", qualification = "Cheerleader", photo = "psyduck.png" });
            people.Add(new Member { name = "Sheri Spruce", qualification = "Cheerleader", photo = "psyduck.png" });
            people.Add(new Member { name = "Burt Indybrick", qualification = "Cheerleader", photo = "psyduck.png" });*/



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
            //        textCell.SetBinding(TextCell.TextProperty, "name");     // name est un attribut d'objet person
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

/*
            listView.ItemsSource = people;
*/
        }

     /*   async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            var modalPage = new MemberDetailPage();
            await Navigation.PushAsync(modalPage);

            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }*/
    }
}
