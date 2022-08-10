using Inventar_2._0.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventar_2._0
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        public class CaseObject
        {
            public static string caseId { get; set; }

            public static string caseTitle { get; set; }

            public static string contactName { get; set; }

            public static string contactNumber { get; set; }

            public static string caseAgentGroup { get; set; }

            public static string caseAgentName { get; set; }

            public static string caseModel { get; set; }

            public static string caseType { get; set; }

            public static string casePrice { get; set; }
        }

        // Events for forskjellige printe metoder.

        // Printing av custom labels.
        private void printCustomBtn_Click(object sender, EventArgs e)
        {
            Funksjoner.Print(customTextBox.Text, "Calibri (Brødtekst)", 11);
        }

        // Printing av siste sak registrert i ffreshdesk.
        private void printLastCaseBtn_Click(object sender, EventArgs e)
        {
            var WEBSERVICE_URL = "https://hdata.freshdesk.com/api/v2/tickets?order_by=created_at";
            try
            {
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                if (webRequest != null)
                {
                    dynamic jsonObject = "";

                    webRequest.Method = "GET";
                    webRequest.Timeout = 12000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", "Basic " + Funksjoner.Base64Encode(ProgramData.ApiKey + ":X"));

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            jsonObject = JsonConvert.DeserializeObject(jsonResponse);

                            caseIdBox.Text = jsonObject[0].id.ToString();
                            printCaseBtn_Click(this, EventArgs.Empty);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void printCaseBtn_Click(object sender, EventArgs e)
        {
            var WEBSERVICE_URL = "https://hdata.freshdesk.com/api/v2/tickets/" + caseIdBox.Text;
            try
            {
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                if (webRequest != null)
                {
                    var contactId = "";
                    dynamic jsonObject = "";

                    webRequest.Method = "GET";
                    webRequest.Timeout = 12000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", "Basic " + Funksjoner.Base64Encode(ProgramData.ApiKey + ":X"));

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            jsonObject = JsonConvert.DeserializeObject(jsonResponse);

                            contactId = jsonObject.requester_id;

                            CaseObject.caseId = jsonObject.id;
                            if (jsonObject.custom_fields.merke_modell_fritekst != null)
                            {
                                CaseObject.caseModel = jsonObject.custom_fields.merke_modell_fritekst;
                            }
                            else
                            {
                                CaseObject.caseModel = jsonObject.custom_fields.apple;
                            }
                            CaseObject.caseType = jsonObject.custom_fields.cf_reparasjons_type;
                            if (jsonObject.custom_fields.cf_avtalt_pris != null)
                            {
                                CaseObject.casePrice = jsonObject.custom_fields.cf_avtalt_pris;
                            }
                            else
                            {
                                CaseObject.casePrice = "N/A";
                            }

                            Dictionary<string, string> groupList = new Dictionary<string, string>();
                            groupList.Add("16000082980", "Farmandstredet");
                            groupList.Add("16000079186", "Holmestrand");
                            groupList.Add("16000083022", "Revetal");
                            groupList.Add("16000076527", "Konsulent");

                            Dictionary<string, string> agentList = new Dictionary<string, string>();
                            agentList["16008665693"] = "Trond";
                            agentList["16015673190"] = "Audun";
                            agentList["16042483413"] = "Anders";
                            agentList["16037130868"] = "Joachim";
                            agentList["16026979649"] = "Kjetil";
                            agentList["16041966656"] = "Henrik";
                            agentList["16043902087"] = "Alexander";

                            CaseObject.caseTitle = jsonObject.subject;

                            CaseObject.caseAgentGroup = groupList[jsonObject.group_id.ToString()];
                            CaseObject.caseAgentName = agentList[jsonObject.responder_id.ToString()];
                        }
                    }

                    // Hent kontakt informasjon.

                    var webservice_kontakt = "https://hdata.freshdesk.com/api/v2/contacts/" + contactId;

                    var webservice_contact = System.Net.WebRequest.Create(webservice_kontakt);

                    webservice_contact.Method = "GET";
                    webservice_contact.Timeout = 12000;
                    webservice_contact.ContentType = "application/json";
                    webservice_contact.Headers.Add("Authorization", "Basic TFg2d2xzdGM1cTZxTlRqWlV4dTpY");

                    try
                    {
                        using (System.IO.Stream s = webservice_contact.GetResponse().GetResponseStream())
                        {
                            using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                            {
                                var jsonResponse = sr.ReadToEnd();
                                jsonObject = JsonConvert.DeserializeObject(jsonResponse);

                                CaseObject.contactName = jsonObject.name;
                                if (jsonObject.mobile != null)
                                {
                                    CaseObject.contactNumber = jsonObject.mobile;
                                }
                                else
                                {
                                    CaseObject.contactNumber = jsonObject.phone;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Problem med å hente kontakt.\nDet er mulig personen er en agent hvis dette skjer.");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sak eksisterer ikke.");
                MessageBox.Show(error.ToString());
            }

            string printLabel = "#" + CaseObject.caseId + "\n" + CaseObject.contactName + "\nTlf: " + CaseObject.contactNumber + "\n" + CaseObject.caseModel + "\n" + CaseObject.caseType + "\n" + CaseObject.casePrice + ",-\n" + CaseObject.caseTitle + "\n" + CaseObject.caseAgentGroup + " - " + CaseObject.caseAgentName;

            Funksjoner.Print(printLabel, "Calibri (Brødtekst)", 9);
        }
    }
}
