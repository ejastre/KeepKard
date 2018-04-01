using System;
using System.Linq;
using KeepKard.Models;
using KeepKard.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace KeepKard.ViewModels
{
    public class HomeViewModel : BindableBase
	{
	    private string _name;
	    public string Name
	    {
	        get => _name;
	        set => SetProperty(ref _name, value);
	    }

	    public DelegateCommand UpdateCommand { get; }
	    public DelegateCommand LoadCommand { get; }

        private INavigationService _navigationService;
        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            Name = "Name Teste 123";

            UpdateCommand = new DelegateCommand(Update);
            LoadCommand = new DelegateCommand(Load);
        }

	    private void Load()
	    {
	        try
	        {
	            //var db = new DbService();
	            //var users = db.Load();

	            ////var user = users.FindOne(x => x.Name.Contains("John"));
	            //var user = users.FindAll().FirstOrDefault();
             //   Name = user.Name;
	        }
	        catch (Exception ex)
	        {
	            
	        }
	    }

	    private void Update()
	    {
	        try
	        {
	            //var user = new User {Name = "John Doe"};

	            //var db = new DbService();
	            //db.Insert(user);
	        }
	        catch (Exception ex)
	        {
	            
	        }
	    }
	}
}
