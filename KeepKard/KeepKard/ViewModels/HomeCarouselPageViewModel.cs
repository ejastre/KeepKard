using System;
using KeepKard.Models;
using KeepKard.Services;
using Prism.Commands;
using Prism.Mvvm;

namespace KeepKard.ViewModels
{
	public class HomeCarouselPageViewModel : BindableBase
	{
        private Personal _personalProfile;
        public Personal PersonalProfile
        {
            get => _personalProfile;
            set => SetProperty(ref _personalProfile, value);
        }

	    public DelegateCommand SavePersonalProfile { get; }

        public HomeCarouselPageViewModel()
        {
            try
            {
                LoadProfile();
                SavePersonalProfile = new DelegateCommand(SavePersonalProfileExecuted);

            }
            catch (Exception ex)
            {

            }
        }

	    private void LoadProfile()
	    {
	        try
	        {
	            var db = new DbService();
	            var personal = db.Get<Personal>();

                PersonalProfile = personal;
            }
	        catch (Exception ex)
	        {

	        }
        }

	    private void SavePersonalProfileExecuted()
	    {
	        try
	        {
	            var db = new DbService();
	            db.Upsert(PersonalProfile);
            }
	        catch (Exception ex)
	        {

	        }
        }
	}
}
