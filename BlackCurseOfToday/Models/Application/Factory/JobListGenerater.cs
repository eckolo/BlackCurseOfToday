using BlackCurseOfToday.Models.Application.Service;
using BlackCurseOfToday.Models.Application.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackCurseOfToday.Models.Application.Factory
{
    /// <summary>
    /// <see cref="Job"/>のリストデータを所定の形で生成する
    /// </summary>
    public static class JobListGenerater
    {
        /// <summary>
        /// ジョブ全体の中から所定の数だけランダムにピックアップする
        /// </summary>
        /// <param name="num">ピックアップ数</param>
        /// <returns>ジョブのリスト</returns>
        public static IEnumerable<Job> ShufflePickUp(int num)
        {
            var allJobs = Enum.GetValues(typeof(Job)).Cast<Job>();

            var healers = allJobs
                .Where(job => job.GetRole() == Role.Healer)
                .OrderBy(_ => Guid.NewGuid())
                .Take(1)
                .ToArray();
            var others = allJobs
                .Except(healers)
                .OrderBy(_ => Guid.NewGuid())
                .Take(num - 1);

            var result = healers.Concat(others).OrderBy(_ => Guid.NewGuid()).ToArray();
            return result;
        }
    }
}
