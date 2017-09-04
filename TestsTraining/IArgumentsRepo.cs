using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsTraining
{
    public interface IArgumentsRepo
    {
        int? GetLeftArgument();
        int? GetRightArgument();
    }
}
