using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reza.TravelManagement.Application.Services
{
    public interface ITravelerCheckListReadService
    {
        Task<bool> ExistsByNameAsync(string name);
    }
}
