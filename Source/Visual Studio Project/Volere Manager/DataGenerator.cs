using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Volere_Manager
{
    class DataGenerator
    {
        Blank dc;
        Random r;
        public DataGenerator(Blank dc)
        {
            r = new Random();
            this.dc = dc;
        }
        public void generateAndInsert()
        {
            int reqRows = 10000;
            int daysFloat = 10;

            String[] loreIpsums = DummyData.data.Split('|');
            var reqTypes = (from r in dc.Req_Types
                           where r.SubNr != 0
                           select r).ToArray();

            for (int i = 0; i < reqRows; i++)
            {
                Req r = new Req();
                r.Created = DateTime.Today.Add(TimeSpan.FromDays(getRandom(daysFloat, false)));
                r.Priority = Convert.ToByte(getRandom(5, true));
                r.Description = loreIpsums[getRandom(loreIpsums.Length, true)];
                r.Req_Types = reqTypes[getRandom(reqTypes.Length, true)];
                r.Satisfaction = Convert.ToByte(getRandom(5, true));
                r.Dissatisfaction = Convert.ToByte(getRandom(5, true));
                r.Fit_criterion = loreIpsums[getRandom(loreIpsums.Length, true)];
                r.Modified = DateTime.Today.Add(TimeSpan.FromDays(getRandom(daysFloat, false)));
                r.Rationale = loreIpsums[getRandom(loreIpsums.Length, true)];

                dc.Req.InsertOnSubmit(r);

            }
            dc.SubmitChanges();
        }

        public int getRandom(int i, Boolean positiveOnly)
        {
            
            if (positiveOnly) return r.Next(1,i);
            return r.Next(-i, i);
        }



        internal void exportTxt(List<Req> reqList, string p)
        {

            StreamWriter SW = new StreamWriter(p);
            String lang = "ENG";
            SW.WriteLine("<html><head><META HTTP-EQUIV=\"Content-Type\" CONTENT=\"text/html; charset=utf-8\"></head>");
            if (lang == "ENG")
            {

                foreach (var i in reqList)
                {
                    SW.WriteLine("<h2>Requirement:</b> " + i.Id.ToString() + "</h2>");
                    SW.WriteLine("<p><b>Type:</b>" + i.Req_Types.Name.ToString() + "<br>");
                    SW.WriteLine("<b>Priority:</b> " + i.Priority.ToString() + "<br>");
                    SW.WriteLine("<b>Customer Satisfaction:</b> " + i.Satisfaction.ToString() + "<br>");
                    SW.WriteLine("<b>Customer Dissatisfaction:</b> " + i.Dissatisfaction.ToString() + "<br>");
                    SW.WriteLine("<b>Originator:</b>" + i.Originator_id.ToString() + "</p>");
                    SW.WriteLine();
                    SW.WriteLine("<h3>Description:</h3>");
                    SW.WriteLine(i.Description.ToString());
                    SW.WriteLine();
                    SW.WriteLine("<h3>Rationale:</h3>");
                    SW.WriteLine(i.Rationale.ToString());
                    SW.WriteLine();
                    SW.WriteLine("<h3>Fit Criterion:</h3>");
                    SW.WriteLine(i.Fit_criterion.ToString());
                    SW.WriteLine();
                    SW.WriteLine();
                    SW.WriteLine();
                }
            }
            else
            {
                foreach (var i in reqList)
                {
                    SW.WriteLine("<h2><b>Nõue:</b> " + i.Id.ToString() + "</h2>");
                    SW.WriteLine("<p><b>Tüüp:</b>" + i.Req_Types.Name.ToString() + "<br>");
                    SW.WriteLine("<b>Prioriteet:</b> " + i.Priority.ToString() + "<br>");
                    SW.WriteLine("<b>Kliendi rahulolu:</b> " + i.Satisfaction.ToString() + "<br>");
                    SW.WriteLine("<b>Kliendi rahulolematus:</b> " + i.Dissatisfaction.ToString() + "<br>");
                    SW.WriteLine("<b>Algataja:</b>" + i.Originator_id.ToString() + "</p>");
                    SW.WriteLine();
                    SW.WriteLine("<h3>Kirjeldus:</h3>");
                    SW.WriteLine(i.Description.ToString());
                    SW.WriteLine();
                    SW.WriteLine("<h3>Vajalikkus:</h3>");
                    SW.WriteLine(i.Rationale.ToString());
                    SW.WriteLine();
                    SW.WriteLine("<h3>Sobivustingimus:</h3>");
                    SW.WriteLine(i.Fit_criterion.ToString());
                    SW.WriteLine("<br><br><br><br>");
                }
            }
            SW.WriteLine("</html>");
            SW.Close();
        }
    }
}
