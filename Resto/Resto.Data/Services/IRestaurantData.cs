using Resto.Data.Models;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> getAll();
        Restaurant get(int id);
        void Add(Restaurant rest);

        void Update(Restaurant rest);

        void Delete(int id);
    }
}
