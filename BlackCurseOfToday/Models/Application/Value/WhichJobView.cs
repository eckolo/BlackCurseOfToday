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
        public List<Job> jobList { get; }

        public List<string> jobNameList => jobList.Select(job => job.GetName()).ToList();
    }
}
