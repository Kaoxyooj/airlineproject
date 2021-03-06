﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class ViewModel
    {
        public string SPsw()
        {
            SmallPlaneSW spSW = new SmallPlaneSW(0, 0, 0, 0, "", "", "", "");
            return spSW.ToString();
        }
        public string SPswInfo()
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            string sold = " Tickets Sold";
            string msg = "-------Flight-1001------------------------------------" + Environment.NewLine+ "Total Revenue : $";
            string generate = p.genPerson().ToString();
            string a;
            string b;
            string c;
            a = sales.SmallSales().ToString();
            b = msg + sales.SmallRevenue(Int32.Parse(a));
            c = b + Environment.NewLine + a + sold;
   
            write.clearManifest1001();
            write.manifestHeader1001();
            while (i < Int32.Parse(a))
            {
                write.writeInfoToManifest1001(p.genPerson().ToString());
                read.readInfoFromManifest1001();
                i++;
            }
            return c;
        }
        public string SPne()
        {
            SmallPlaneNE spNE = new SmallPlaneNE(0, 0, 0, 0, "", "", "", "");
            return spNE.ToString();
        }
        public string SPneInfo()
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            string sold = " Tickets Sold";
            string msg = "-------Flight-1002-----------------------------------" + Environment.NewLine+ "Total Revenue : $";
            string generate = p.genPerson().ToString();
            string a;
            string b;
            string c;
            a = sales.SmallSales().ToString();
            b = msg + sales.SmallRevenue(Int32.Parse(a));
            c = b + Environment.NewLine + a + sold;
            
            write.clearManifest1002();
            write.manifestHeader1002();
            while (i < Int32.Parse(a))
            {
                write.writeInfoToManifest1002(p.genPerson().ToString());
                read.readInfoFromManifest1002();
                i++;
            }
            return c;
        }
        public string MPsw()
        {
            MediumPlaneSW mpSW = new MediumPlaneSW(0, 0, 0, 0, "", "", "", 0, "");
            return mpSW.ToString();
        }
        public string MPswInfo()
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            int amount;
            int amountFirst;
            int amountCoach;
            string sold = " Tickets Sold";
            string msg = "-------Flight-101-------------------------------------" + Environment.NewLine+ "Total Revenue : $";
            string generate = p.genPerson().ToString();
            string a;
            string b;
            string c;
            amountFirst = sales.MediumRev1st(sales.MediumSales1st());
            amountCoach = sales.MediumRevCoach(sales.MediumSalesCoach());
            amount = sales.MediumSalesCoach() + sales.MediumSales1st();
            a = amount.ToString();
            b = msg + sales.TotalMediumRevenue(amountFirst, amountCoach);
            c = b + Environment.NewLine + a + sold;
            
            write.clearManifest101();
            write.manifestHeader101();
            while (i < Int32.Parse(a))
            {
                write.writeInfoToManifest101(p.genPerson().ToString());
                read.readInfoFromManifest101();
                i++;
            }
            return c;
        }
        public string MPne()
        {
            MediumPlaneNE mpNE = new MediumPlaneNE(0, 0, 0, 0, "", "", "", 0, "");
            return mpNE.ToString();
        }
        public string MPneInfo()
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            int amount;
            int amountFirst;
            int amountCoach;
            string sold = " Tickets Sold";
            string msg =  "-------Flight-102-------------------------------------"+Environment.NewLine+ "Total Revenue : $";
            string generate = p.genPerson().ToString();
            string a;
            string b;
            string c;
            amountFirst = sales.MediumRev1st(sales.MediumSales1st());
            amountCoach = sales.MediumRevCoach(sales.MediumSalesCoach());
            amount = sales.MediumSalesCoach() + sales.MediumSales1st();
            a = amount.ToString();
            b = msg + sales.TotalMediumRevenue(amountFirst, amountCoach);
            c = b + Environment.NewLine + a + sold;
            
            write.clearManifest102();
            write.manifestHeader102();
            while (i < Int32.Parse(a))
            {
                write.writeInfoToManifest102(p.genPerson().ToString());
                read.readInfoFromManifest102();
                i++;
            }
            return c;
        }
        public string BPsw()
        {
            BigPlaneSW bpSW = new BigPlaneSW(0, 0, 0, 0, "", "", "", 0, "");
            return bpSW.ToString();
        }
        public string BPswInfo()
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            int amount;
            int amountFirst;
            int amountCoach;
            string sold = " Tickets Sold";
            string msg = "-------Flight-11--------------------------------------" + Environment.NewLine+ "Total Revenue : $";
            string generate = p.genPerson().ToString();
            string a;
            string b;
            string c;
            amountFirst = sales.LargeRev1st(sales.LargeSales1st());
            amountCoach = sales.LargeRevCoach(sales.LargeSalesCoach());
            amount = sales.LargeSalesCoach() + sales.LargeSales1st();
            a = amount.ToString();
            b = msg + sales.TotalLargeRevenue(amountFirst, amountCoach);
            c = b + Environment.NewLine + a + sold;
            
            write.clearManifest11();
            write.manifestHeader11();
            while (i < Int32.Parse(a))
            {
                write.writeInfoToManifest11(p.genPerson().ToString());
                read.readInfoFromManifest11();
                i++;
            }
            return c;
        }
        public string BPne()
        {
            BigPlaneNE bpNE = new BigPlaneNE(0, 0, 0, 0, "", "", "", 0, "");
            return bpNE.ToString();
        }
        public string BPneInfo()
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            int amount;
            int amountFirst;
            int amountCoach;
            string sold = " Tickets Sold";
            string msg = "-------Flight-12--------------------------------------" + Environment.NewLine+ "Total Revenue : $";
            string generate = p.genPerson().ToString();
            string a;
            string b;
            string c;
            amountFirst = sales.LargeRev1st(sales.LargeSales1st());
            amountCoach = sales.LargeRevCoach(sales.LargeSalesCoach());
            amount = sales.LargeSalesCoach() + sales.LargeSales1st();
            a = amount.ToString();
            b = msg + sales.TotalLargeRevenue(amountFirst, amountCoach);
            c = b + Environment.NewLine + a + sold;
            
            write.clearManifest12();
            write.manifestHeader12();
            while (i < Int32.Parse(a))
            {
                write.writeInfoToManifest12(p.genPerson().ToString());
                read.readInfoFromManifest12();
                i++;
            }
            return c;
        }
    }

}
