using System.Collections.Generic;
using System.Windows.Forms;
using Corax.Core.Client.Classes;

namespace Corax.Core.Client.Controls
{
    public partial class UserControlBase : UserControl, IMessageSink
    {
        private static List<IMessageSink> messageSinks;

        static UserControlBase()
        {
            messageSinks = new List<IMessageSink>();
        }

        protected UserControlBase()
        {

        }

        public void RegisterMessageSink(IMessageSink sink)
        {
            if(! messageSinks.Contains(sink))
            {
                messageSinks.Add(sink);
            }
        }

        public void UnregisterMessageSink(IMessageSink sink)
        {
            if (messageSinks.Contains(sink))
            {
                messageSinks.Remove(sink);
            }
        }

        public void AddMessage(string message)
        {
            if (messageSinks != null)
            {
                messageSinks.ForEach(s => s.AddMessage(message));
            }
        }

        public void AddLine()
        {
            if (messageSinks != null)
            {
                messageSinks.ForEach(s => s.AddLine());
            }
        }

        public void AddLines(int lineCount)
        {
            if (messageSinks != null)
            {
                messageSinks.ForEach(s => s.AddLines(lineCount));
            }
        }

        public void ClearMessages()
        {
            if (messageSinks != null)
            {
                messageSinks.ForEach(s => s.ClearMessages());
            }
        }
    }
}
