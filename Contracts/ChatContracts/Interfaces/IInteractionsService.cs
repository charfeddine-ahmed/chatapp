using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatContracts.Interfaces
{
    interface IInteractionsService
    {
        bool SendDirectMessage(string destination, string message);

        void JoinRoom(string roomName);

        void LeaveRoom(string roomName);

        void SendBroadcastMessage(string roomName, string message);
    }
}
