using System.Linq;
using System.Collections.Generic;

namespace JMeterApp.Common.Models
{
    public class VoteCandidate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }

    public static class VoteCandidateFactory
    {
        static readonly List<VoteCandidate> _voteCandidates = new List<VoteCandidate>()
        {
            new VoteCandidate(){
                ID=0,
                Name = "窓辺ななみ",
                Description = "Windows 7 のマスコットキャラクター、とても素敵",
                ImgUrl = @"http://i.msdn.microsoft.com/hh184191.Cloud_ep0_c02(ja-jp,MSDN.10).jpg"
            },
            new VoteCandidate(){
                ID=1,
                Name = "クラウディア窓辺",
                Description = "Windows 1.0 の発売日に彼女は生まれた Windows Azure の伝道師？",
                ImgUrl = @"http://i.msdn.microsoft.com/hh184191.Cloud_ep0_c01(ja-jp,MSDN.10).jpg"
            },
            new VoteCandidate(){
                ID=2,
                Name = "店長",
                Description = "年齢不詳だがマジイケメン、うほっ(´∀｀*)ﾎﾟｯ",
                ImgUrl = @"http://i.msdn.microsoft.com/hh184191.Cloud_ep0_c04(ja-jp,MSDN.10).jpg"
            },
            new VoteCandidate(){
                ID=3,
                Name = "クロード窓辺",
                Description = "マイクロソフトの設立日生まれのイケメン、うほっ(´∀｀*)ﾎﾟｯ",
                ImgUrl = @"http://i.msdn.microsoft.com/hh184191.Cloud_ep2_c03(ja-jp,MSDN.10).jpg"
            }
        };

        public static List<VoteCandidate> VoteCandidates
        {
            get
            {
                return _voteCandidates;
            }
        }
    }
}
