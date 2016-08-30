using System.Collections.Generic;
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
                    IconSource = "Monkeyicon.png",
                    TargetType = typeof(PresentationCEMPage)
                },
                new MasterPageItem
                {
                    Title = "Nos Références",
                    IconSource = "Monkeyicon.png",
                    TargetType = typeof(ReferencesPage)
                },
                new MasterPageItem
                {
                    Title = "Fil d'actualité",
                    IconSource = "Monkeyicon.png",
                    TargetType = typeof(NewsPage)
                },
                new MasterPageItem
                {
                    Title = "Quizz",
                    IconSource = "Monkeyicon.png",
                    TargetType = typeof(QuizzPage)
                }
            };


            listView.ItemsSource = masterPageItems;
        }
    }
}
