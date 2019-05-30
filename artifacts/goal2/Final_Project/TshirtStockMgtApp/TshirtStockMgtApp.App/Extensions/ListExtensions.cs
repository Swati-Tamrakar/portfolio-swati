using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TshirtStockMgtApp.App.Extensions
{
   public static class ListExtensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> collection)
        {
            var obsCollection = new ObservableCollection<T>();
            foreach (var obj in collection)
                obsCollection.Add(obj);
            return obsCollection;
        }
    }
}
