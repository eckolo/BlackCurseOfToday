using BlackCurseOfToday.Models.Application.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackCurseOfToday.Models.Application.Service
{
    /// <summary>
    /// <see cref="Role"/>クラスのプロパティ的に振る舞うクラス群
    /// </summary>
    public static class RoleProperty
    {
        static readonly Dictionary<Role, string> roleColorClassMap = new Dictionary<Role, string>
        {
            { Role.Attacker, "list-group-item-danger" },
            { Role.Healer, "list-group-item-success" },
            { Role.Tank, "list-group-item-info" },
        };
        public static string GetColorClass(this Role role)
            => roleColorClassMap.ContainsKey(role)
                ? roleColorClassMap[role]
                : throw new ArgumentOutOfRangeException(nameof(role));
    }
}
