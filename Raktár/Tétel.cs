using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktár
{
    class Tétel
    {
        private string kod;

        public string Kod
        {
            get { return kod; }
            set { kod = value; }
        }

        private int db;

        public int Db
        {
            get { return db; }
            set { db = value; }
        }

        public Tétel(string kod, int db)
        {
            this.kod = kod;
            this.db = db;
        
        }

    }
}
