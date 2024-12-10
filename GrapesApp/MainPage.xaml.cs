using GrapesApp.Models;

namespace GrapesApp
{
    public partial class MainPage : ContentPage
    {
        public List<GrapesInfo> GrapesInformation { get; set; }

        public MainPage()
        {
            InitializeComponent();
            GrapesInformation = new List<GrapesInfo>
            {
                new GrapesInfo
                {
                    Micronutrient = "Vitamin C",
                    Percentage = 101
                },
                new GrapesInfo
                {
                    Micronutrient = "Vitamin A",
                    Percentage = 19
                },
                new GrapesInfo
                {
                    Micronutrient = "Calcium",
                    Percentage = 2
                },
                new GrapesInfo
                {
                    Micronutrient = "Magnesium",
                    Percentage = 5
                },
                new GrapesInfo
                {
                    Micronutrient = "Potassium",
                    Percentage = 5
                },
            };
            this.BindingContext = this;
        }

        
    }

}
