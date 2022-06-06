using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShip.model
{
    public interface IShip
    {
        int Loading { get; set; }

        // загрузить на величину weight
        bool TryLoad(int weight);

        // разгрузить на величину weight
        bool TryUnload(int weight);

    }
}
