using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetMonitor.modelo
{
    public class Dado
    {

        private long id { get; set; }
        private bool ativo { get; set; }
        private Alarme alarme { get; set; }

    }
}