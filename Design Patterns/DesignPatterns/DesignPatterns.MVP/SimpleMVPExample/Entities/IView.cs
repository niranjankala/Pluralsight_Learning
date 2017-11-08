using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MVP.SimpleMVPExample.Entities
{
    public interface IView
    {
        string TextValue { get; set; }
    }
}
