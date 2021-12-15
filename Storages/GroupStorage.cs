using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{

        public class GroupStorage
        {
            private Dictionary<int, Group> Groups { get; } = new Dictionary<int, Group>();

            public void Create(Group group)
            {
                Groups.Add(group.GroupId, group);
            }

            public Group Read(int groupId)
            {
                return Groups[groupId];
            }

            public Group Update(int groupId, Group newGroup)
            {
                Groups[groupId] = newGroup;
                return Groups[groupId];
            }

            public bool Delete(int groupId)
            {
                return Groups.Remove(groupId);
            }
        }
    
}