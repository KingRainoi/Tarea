using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamesapp
{
    class Tiempo
    {
        private string day;
        private string inicioH;
        private string inicioM;

        private string finH;
        private string finM;

        public string Day { get => day; set => day = value; }
        public string InicioH { get => inicioH; set => inicioH = value; }
        public string InicioM { get => inicioM; set => inicioM = value; }
        public string FinH { get => finH; set => finH = value; }
        public string FinM { get => finM; set => finM = value; }
    }
}
