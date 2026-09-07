using DataAccess;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Registry
    {
        public static async Task FillDefaultDataAsync()
        {
            await DatabaseRegistry.FillDefaultDataAsync();
        }
    }
}