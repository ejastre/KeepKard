using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KeepKard.Views
{
    public partial class HomeCarouselPage : CarouselPage
    {
        public HomeCarouselPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            try
            {
                QrCodeImage.IsVisible = false;
                PersonalDataFrame.IsVisible = false;
                PersonalEditFrame.IsVisible = true;

                //await PersonalEditFrame.FadeTo(1, 4000);
            }
            catch (Exception ex)
            {

            }
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                QrCodeImage.IsVisible = true;
                PersonalDataFrame.IsVisible = true;
                PersonalEditFrame.IsVisible = false;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void CheckBox_OnTapped(object sender, EventArgs e)
        {
            try
            {
                //if (((Image)sender).Source is FileImageSource source)
                //    NameCheckBox.Source = source.File.Equals("Icon_CheckBlack.png") ? "Icon_CheckBlank.png" : "Icon_CheckBlack.png";
            }
            catch (Exception ex)
            {

            }
        }
    }
}
