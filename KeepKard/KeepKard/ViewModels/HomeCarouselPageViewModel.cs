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

        private PersonalPage _personalPage;
        public PersonalPage PersonalPage2
        {
            get => _personalPage;
            set => SetProperty(ref _personalPage, value);
        }

        public DelegateCommand<string> SaveProfile { get; }
        public DelegateCommand<string> EditProfile { get; }

        public HomeCarouselPageViewModel()
        {
            try
            {
                LoadProfile();
                SaveProfile = new DelegateCommand<string>(SaveProfileExecuted);
                EditProfile = new DelegateCommand<string>(EditProfileExecuted);
            }
            catch (Exception ex)
            {

            }
        }

        private void EditProfileExecuted(string profile)
        {
            try
            {
                PersonalPage2.EditFrame = true;
                PersonalPage2.DataFrame = false;
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

                PersonalPage2 = new PersonalPage
                {
                    EditFrame = false,
                    DataFrame = true
                };
            }
            catch (Exception ex)
            {

            }
        }

        private void SaveProfileExecuted(string profile)
        {
            try
            {
                var db = new DbService();
                db.Upsert(PersonalProfile);

                //BUG Resolver
                PersonalPage2.EditFrame = false;
                PersonalPage2.DataFrame = true;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
