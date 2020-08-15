using Resto.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> getAll();
    }
}
