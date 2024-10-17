using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quests
{
    public class Enums
    {
        public enum QuestType
        {
            Gather,
            Kill,
            Loot,
        }
        public enum QuestRequirementType
        {
            None,
            QuestFinished,
            QuestNotFinished,
            HasPermision,
        }
    }
}
