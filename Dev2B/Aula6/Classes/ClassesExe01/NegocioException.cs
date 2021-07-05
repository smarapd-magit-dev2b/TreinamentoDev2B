using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Classes.ClassesExe01 {
    class NegocioException : Exception {
        public NegocioException(string message) : base(message) {
        }
    }
}
