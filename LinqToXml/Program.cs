using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            BaiYuLou baiYuLou = new BaiYuLou();
            baiYuLou.GenerateDeck();

            BoLiShenShe boLiShenShe = new BoLiShenShe();
            boLiShenShe.GenerateDeck();

            DiLingDian diLingDian = new DiLingDian();
            diLingDian.GenerateDeck();

            HongMoGuan hongMoGuan = new HongMoGuan();
            hongMoGuan.GenerateDeck();

            MingLianSi mingLianSi = new MingLianSi();
            mingLianSi.GenerateDeck();

            MoFaZhiSen moFaZhiSen = new MoFaZhiSen();
            moFaZhiSen.GenerateDeck();

            ShenLingMiao shenLingMiao = new ShenLingMiao();
            shenLingMiao.GenerateDeck();

            ShouShiShenShe shouShiShenShe = new ShouShiShenShe();
            shouShiShenShe.GenerateDeck();

            ShouDao shouDao = new ShouDao();
            shouDao.GenerateDeck();

            YongYuanTing yongYuanTing = new YongYuanTing();
            yongYuanTing.GenerateDeck();
        }
    }
}
