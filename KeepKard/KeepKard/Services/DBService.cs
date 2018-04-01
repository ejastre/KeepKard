using System;
using System.Linq;
using KeepKard.Helpers;
using KeepKard.Models;
using LiteDB;
using Xamarin.Forms;

namespace KeepKard.Services
{
    public class DbService
    {
        private readonly LiteDatabase _dataBase;

        public DbService()
        {
            try
            {
                _dataBase = new LiteDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("MeuBanco.db"));
            }
            catch (Exception ex)
            {
                
            }
        }

        public T Get<T>()
        {
            try
            {
                var objs = _dataBase.GetCollection<T>();
                return objs.FindAll().FirstOrDefault();
            }
            catch (Exception ex)
            {
                return (T) new object();
            }
        }

        public LiteCollection<T> GetList<T>()
        {
            try
            {
                var objs = _dataBase.GetCollection<T>();
                return objs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Upsert<T>(T obj)
        {
            try
            {
                var objs = _dataBase.GetCollection<T>();
                objs.Upsert(obj);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
