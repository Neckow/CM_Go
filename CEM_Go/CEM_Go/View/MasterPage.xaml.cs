using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colimo.Model;
using Xamarin.Forms;

namespace CEM_Go.View
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView => listView;

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "Presentation",
                    IconSource = "icon.png",
                    TargetType = typeof(PresentationCEMPage)
                },
                new MasterPageItem
                {
                    Title = "Nos Références",
                    IconSource = "icon.png",
                    TargetType = typeof(ReferencesPage)
                },
                new MasterPageItem
                {
                    Title = "Fil d'actualité",
                    IconSource = "icon.png",
                    TargetType = typeof(NewsPage)
                },
                new MasterPageItem
                {
                    Title = "Quizz",
                    IconSource = "icon.png",
                    TargetType = typeof(QuizzPage)
                }
            };


            listView.ItemsSource = masterPageItems;
        }
    }
}
