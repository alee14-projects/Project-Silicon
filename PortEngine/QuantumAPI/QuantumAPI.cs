﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PortEngine
{
    public class QuantumnetAPI
    {

        private static void loadSite(UserControl site, Panel pnlSiteArea)
        {
            pnlSiteArea.Controls.Clear();
            pnlSiteArea.Controls.Add(site);
        }

        public static void navigateToSite(TextBox txtNavigateToThis, Panel pnlLoadSiteHere)
        {
            switch (txtNavigateToThis.Text)
            {
                case "quantumconnections.qt":
                    loadSite(new QuantumAPI.Sites.QuantumISP(), pnlLoadSiteHere);
                    break;
                case "malwarebits.qt":
                    loadSite(new Malwarebits(), pnlLoadSiteHere);
                    break;
                default:
                    loadSite(new QuantumAPI.Sites._404Error(), pnlLoadSiteHere);
                    break;
            }

        }
    }
}
