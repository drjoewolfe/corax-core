using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corax.Core.Client.Classes
{
    public interface IMessageSink
    {
        void AddMessage(string message);

        void AddLine();

        void AddLines(int lineCount);

        void ClearMessages();
    }
}
