using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    internal class ComptabiliteException : Exception
    {
        private Facture facture;
        public ComptabiliteException()
        {
        }

        public ComptabiliteException(string message) : base(message)
        {
        }

        public ComptabiliteException(string message, Facture facture) : base(message)
        {
            this.facture = facture;
        }

        public ComptabiliteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ComptabiliteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string ToString()
        {
            string infos = $"ComptabiliteException : {Message}\n";
            if (facture != null)
                infos += facture;
            return infos;
        }
    }
}
