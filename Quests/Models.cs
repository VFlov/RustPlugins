using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quests.Enums;


namespace Quests
{
    public class Quest
    {
        public string QuestID { get; private set; }
        public QuestType QuestType { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public (string, int) QuestTargetPrefab { get; private set; }
        public (string, int) QuestRewardPrefab { get; private set; }
        public QuestRequirementType QuestRequirement { get; private set; }
        public Quest(string questID, QuestType questType, string name, string description, (string, int) questTargetPrefab, (string, int) questRewardPrefab, QuestRequirementType questRequirement)
        {
            QuestID = questID;
            QuestType = questType;
            Name = name;
            Description = description;
            QuestTargetPrefab = questTargetPrefab;
            QuestRewardPrefab = questRewardPrefab;
            QuestRequirement = questRequirement;
        }
    }
    class PlayerProgress
    {
        public uint PlayerId { get; private set; }
        public string PlayerName { get; private set; }
        public string[] QuestComplited { get; set; }
        public int QuestProgressCount { get; set; }

        public PlayerProgress(uint playerId, string playerName, string[] questComplited, int questProgressCount)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            QuestComplited = questComplited;
            QuestProgressCount = questProgressCount;
        }
    }
}
