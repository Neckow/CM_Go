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
                    IconSource = "action1.png",
                    TargetType = typeof(PresentationCEMPage)
                },
                new MasterPageItem
                {
                    Title = "Nos Références",
                    IconSource = "gotcha.png",
                    TargetType = typeof(ReferencesPage)
                },
                new MasterPageItem
                {
                    Title = "Fil d'actualité",
                    IconSource = "psyduck.png",
                    TargetType = typeof(NewsPage)
                },
                new MasterPageItem
                {
                    Title = "Quizz",
                    IconSource = "battle.png",
                    TargetType = typeof(QuizzPage)
                }
            };


            listView.ItemsSource = masterPageItems;
        }
    }
}
