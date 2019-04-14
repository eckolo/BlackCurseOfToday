using BlackCurseOfToday.Models.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackCurseOfToday.Models.Application.Value
{
    /// <summary>
    /// ジョブ選択画面のビューモデル
    /// </summary>
    public class WhichJobView
    {
        public WhichJobView(List<Job> jobList)
        {
            this.jobList = jobList;
        }

        /// <summary>
        /// 今回のジョブの並び
        /// </summary>
        readonly List<Job> jobList = new List<Job>();
        /// <summary>
        /// 表示用ジョブ情報リスト
        /// </summary>
        public List<PerJob> jobDataList => jobList
            .Select(job => new PerJob(job.GetName(), job.GetRole().GetColorClass()))
            .ToList();

        /// <summary>
        /// ジョブ1項目毎の情報
        /// </summary>
        public class PerJob
        {
            public PerJob(string name, string colorClass)
            {
                this.name = name ?? throw new ArgumentNullException(nameof(name));
                this.colorClass = colorClass ?? throw new ArgumentNullException(nameof(colorClass));
            }

            /// <summary>
            /// 表示名
            /// </summary>
            public string name { get; }
            /// <summary>
            /// 色調整用のクラス
            /// </summary>
            public string colorClass { get; }
        }
    }
}
