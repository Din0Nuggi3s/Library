using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenisApi
{
    public interface IDenis_Api
    {
        public Task<int> GetCountAsync();
        public Task<List<int>> GetTotalCountAsync();
        public Task<List<string>> GetTotalNameAsync();
    }
}
