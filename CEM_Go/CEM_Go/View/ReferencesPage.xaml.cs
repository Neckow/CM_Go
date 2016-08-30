using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using CEM_Go.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CEM_Go.View
{
    public partial class ReferencesPage : ContentPage
    {
        private ObservableCollection<GroupedReferenceModel> GroupedReferences { get; }

        public ReferencesPage()
        {
            InitializeComponent();

            GroupedReferences = new ObservableCollection<GroupedReferenceModel>();

            var assembly = typeof(ReferencesPage).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("CEM_Go.Data.json");

           /* string jsonString;
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                DependencyService.Get<ISaveAndLoad>().SaveText("Data.json", json);
                jsonString = DependencyService.Get<ISaveAndLoad>().LoadText("Data.json");
            }
*/

            List<Reference> references;
            List<Sector> sectors;


            /*
             * @brief Parse JSON file Data.json
             * @return references array & orderedSector which is list of sector ordered by id
             */
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var allReferences = JsonConvert.DeserializeObject<AllReferences>(json);
                references = allReferences.references;
                references = references.OrderBy(o => o.project).ToList();

                var allSector = JsonConvert.DeserializeObject<AllSector>(json);
                sectors = allSector.sectors;
                sectors = sectors.OrderBy(x => x.id).ToList();
            }
            ListSorting(references, sectors);

            /* Binding from code to View */
            listView.ItemsSource = GroupedReferences;

        }

        /*
        * @brief Add references in their respective section 
        * @return Collection of section and hide empty section
        */
        private void ListSorting(List<Reference> references, List<Sector> sectors)
        {
            foreach (var s in sectors)
            {
                var group = new GroupedReferenceModel() { LongName = s.name };

                foreach (var r in references)
                {
                    if (group.LongName == r.sector)
                    {
                        group.Add(r);
                    }
                }
                if (group.Any())
                {
                    GroupedReferences.Add(group);
                }
            }
        }

        /*
         *  @brief Goto Reference detail page when element in reference list is selected 
        */

        private async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            var reference = (Reference)e.SelectedItem;

            var modalPage = new ReferenceDetailPage { BindingContext = reference };
            await Navigation.PushAsync(modalPage);

            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }
    }
}
