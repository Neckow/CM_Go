using System;
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
        private IOrderedEnumerable<Sector> orderedSector { get; set; }
        private ObservableCollection<GroupedReferenceModel> groupedReferences { get; set; }

        public ReferencesPage()
        {
            InitializeComponent();

            groupedReferences = new ObservableCollection<GroupedReferenceModel>();

            var assembly = typeof(ReferencesPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("CEM_Go.Data.json");

            Reference[] references;
            Sector[] secteurs;
            

            /*
             * @brief Parse JSON file Data.json
             * @return references array & orderedSector which is list of sector ordered by id
             */
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var allReferences = JsonConvert.DeserializeObject<AllReferences>(json);
                references = allReferences.references;
                Array.Sort(references, (x, y) => string.CompareOrdinal(x.project, y.project));

                var allSector = JsonConvert.DeserializeObject<AllSector>(json);
                secteurs = allSector.secteurs;

                orderedSector = secteurs.OrderBy(x => x.id);
            }

            /*
             * @brief Add references in their respective section 
             * @return Collection of section and hide empty section
             */
            foreach (var s in orderedSector)
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
                    groupedReferences.Add(group);
                }
            }

            // Binding from code to View
            listView.ItemsSource = groupedReferences;

        }
    }
}
