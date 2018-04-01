using System;
using System.IO;
using KeepKard.Droid.Helpers;
using KeepKard.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace KeepKard.Droid.Helpers
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}