using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace WebApplication1.Data
{
    public class EFFoodRepository : IFoodRepository
    {
        private FoodContext _foodContext;

        public EFFoodRepository(FoodContext temp) {
            _foodContext = temp;
        }

        public IEnumerable<MarriottFood> Foods => _foodContext.Foods;
    }
}
