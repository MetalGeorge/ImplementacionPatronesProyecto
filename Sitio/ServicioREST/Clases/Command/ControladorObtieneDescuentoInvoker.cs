using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioREST.Clases.Command
{
    public class ControladorObtieneDescuentoInvoker : IInvoker
    {
        IDescuentosCommand command;

        public void SetCommand(IDescuentosCommand command)
        {
            this.command = command;
        }

        public int? Invoke()
        {
            return command.Execute();
        }
    }
}