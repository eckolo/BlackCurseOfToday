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
        public static IOrderedEnumerable<Job> ShufflePickUp(int num)
            => Enum.GetValues(typeof(Job))
                .Cast<Job>()
                .OrderBy(_ => Guid.NewGuid())
                .Take(num)
                .OrderBy(_ => Guid.NewGuid());
    }
}
