using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUI.Core.Services;
public interface ICoreMessageService
{
    Task ConfirmMessage(string message, Action action, string title = null);
}
