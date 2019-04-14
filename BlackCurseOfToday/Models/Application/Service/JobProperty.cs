using BlackCurseOfToday.Models.Application.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackCurseOfToday.Models.Application.Service
{
    /// <summary>
    /// <see cref="Job"/>クラスのプロパティ的に振る舞うクラス群
    /// </summary>
    public static class JobProperty
    {
        static readonly Dictionary<Job, string> jobNameMap = new Dictionary<Job, string>
        {
            { Job.Fighter, "ファイター" },
            { Job.Hunter, "ハンター" },
            { Job.Priest, "プリースト" },
            { Job.ShieldSage, "シールドセージ" },
            { Job.Seeker, "シーカー" },
            { Job.Sorcerer, "ソーサラー" },
            { Job.ElementArcher, "エレメントアーチャー" },
            { Job.Warrior, "ウォリアー" },
            { Job.Alchemist, "アルケミスト" },
            { Job.SpiritLancer, "スピリットランサー" },
            { Job.HighScepter, "ハイセプター" },
        };
        public static string GetName(this Job job)
            => jobNameMap.ContainsKey(job)
                ? jobNameMap[job]
                : throw new ArgumentOutOfRangeException(nameof(job));

        static readonly Dictionary<Job, Role> jobRoleMap = new Dictionary<Job, Role>
        {
            { Job.Fighter, Role.Attacker },
            { Job.Hunter, Role.Attacker },
            { Job.Priest, Role.Healer },
            { Job.ShieldSage, Role.Tank },
            { Job.Seeker, Role.Attacker },
            { Job.Sorcerer, Role.Attacker },
            { Job.ElementArcher, Role.Healer },
            { Job.Warrior, Role.Attacker },
            { Job.Alchemist, Role.Tank },
            { Job.SpiritLancer, Role.Healer },
            { Job.HighScepter, Role.Attacker },
        };
        public static Role GetRole(this Job job)
            => jobRoleMap.ContainsKey(job)
                ? jobRoleMap[job]
                : throw new ArgumentOutOfRangeException(nameof(job));
    }
}
