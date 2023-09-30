using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.RankViewModels
{
    public class RankView
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NecessaryPoints { get; set; }
        public string Description { get; set; }
    }
}