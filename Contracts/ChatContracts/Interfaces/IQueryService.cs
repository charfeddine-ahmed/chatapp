using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatContracts.Data;

namespace ChatContracts.Interfaces
{
    interface IQueryService
    {
        List<Room> GetRoomsList();

        List<Participant> GetParticipantsList();
    }
}
