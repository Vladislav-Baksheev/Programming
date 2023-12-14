using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит диапазоны времени доставки.
    /// </summary>
    public enum DeliveryTime
    {
        FromNineToEleven,
        FromElevenToThirteen,
        FromThirteenToFifteen,
        FromFifteenToSeventeen,
        FromSeventeenToNineteen,
        FromNineteenToTwentyOne,
        None,
    }
}
