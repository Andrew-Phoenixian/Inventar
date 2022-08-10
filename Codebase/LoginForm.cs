using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Inventar_2._0.Classes;
using MySql.Data.MySqlClient;

namespace Inventar_2._0
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // EVENTS
        private void logInBtn_Click(object sender, EventArgs e)
        {
            // Sånn at vi er sikker på at public class har den info den trenger.
            ProgramData.Username = usernameBox.Text;
            ProgramData.Password = passwordBox.Text;
            ProgramData.RememberMe = rememberMeBox.Checked;

            // Lagre innstillinger om vi skal lagre til neste gang.
            if (rememberMeBox.Checked)
            {
                Properties.Settings.Default.Username = usernameBox.Text;
                Properties.Settings.Default.Password = passwordBox.Text;
            }
            else
            {
                Properties.Settings.Default.Username = "Brukernavn";
                Properties.Settings.Default.Password = "Passord";
            }

            if (autoLogInBox.Checked)
            {
                Properties.Settings.Default.autoLogIn = true;
            }
            else
            {
                Properties.Settings.Default.autoLogIn = false;
            }

            Properties.Settings.Default.Save();

            // Attempt to Login //

            // Parameter template: {name_of_var, type_of_var, direction_input_or_output}
            object[] Parameters = new object[] { new object[] {"@fullnamevar", MySqlDbType.VarChar, ParameterDirection.Output}, new object[] { "@locationvar", MySqlDbType.VarChar, ParameterDirection.Output }, new object[] { "@fd_apikeyvalue", MySqlDbType.VarChar, ParameterDirection.Output }, new object[] { "@isadminvar", MySqlDbType.VarChar, ParameterDirection.Output } };
            
            try
            {
                MySqlCommand LoginData = DatabaseHelper.executeStoredProcedure("fetch_account", Parameters);

                ProgramData.FullName = LoginData.Parameters["@fullnamevar"].Value.ToString();
                ProgramData.LocationName = LoginData.Parameters["@locationvar"].Value.ToString();
                ProgramData.ApiKey = LoginData.Parameters["@fd_apikeyvalue"].Value.ToString();

                Dashboard dashboardFrame = new Dashboard();
                this.Hide();
                dashboardFrame.Show();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Feil login eller database feil.");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Håndtere oppdatering. Sjekk nåværende versjon mot versjon som er i xml på github.
             */

            versionText.Text = "v" + Application.ProductVersion.ToString();

            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;

            AutoUpdater.DownloadPath = Application.StartupPath;
            AutoUpdater.Start("https://raw.githubusercontent.com/Andrew-Phoenixian/Inventar/main/version.xml");

            // ETTER OPPDATERING/SJEKK, få inn lagret brukernavn hvis det finnes.

            usernameBox.Text = Properties.Settings.Default.Username;
            passwordBox.Text = Properties.Settings.Default.Password;

            if (usernameBox.Text != "Brukernavn")
            {
                passwordBox.UseSystemPasswordChar = true;
                rememberMeBox.Checked = true;
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.autoLogIn)
            {
                autoLogInBox.Checked = true;
                logInBtn_Click(this, EventArgs.Empty);
            }
        }

        /*
         *  Dette bruker jeg pga. er ingen Norsk versjon til det som kommer standard, så jeg gjør det vrient og håndterer det selv.
         */
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.Error == null)
            {
                if (args.IsUpdateAvailable)
                {
                    DialogResult dialogResult;
                    if (args.Mandatory.Value)
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"Det er en ny versjon {args.CurrentVersion} tilgjengelig. Du bruker versjon {args.InstalledVersion}. Dette er en nødvendig oppdatering. Trykk OK for å starte oppdateringen.", @"Oppdatering Tilgjengelig",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"Det er en ny versjon {args.CurrentVersion} tilgjengelig. Du bruker versjon {
                                        args.InstalledVersion
                                    }. Vil du oppdatere nå?", @"Oppdatering Tilgjengelig",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                    }

                    // AutoUpdater.ShowUpdateForm(args);

                    if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                    {
                        try
                        {
                            if (AutoUpdater.DownloadUpdate(args))
                            {
                                Application.Exit();
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                 //   MessageBox.Show(@"Det er ingen oppdatering tilgjenglig, vennligst prøv igjen senere.", @"Ingen oppdatering tilgjengelig",
                 //       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (args.Error is WebException)
                {
                    MessageBox.Show(
                        @"Det oppsto et problem under henting av programvareversjon fra server. Sjekk nettverkskoblingen din og prøv igjen eller kontakt Anders.",
                        @"Opdatering sjekk feilet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(args.Error.Message,
                        args.Error.GetType().ToString(), MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // BARE FOR AT DET SKAL SE BRA UT
        private void usernameBox_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            usernamePicture.Image = Properties.Resources.username_selected;
            usernamePanelLine.BackColor = Color.FromArgb(78, 184, 206);
            usernameBox.ForeColor = Color.FromArgb(78, 184, 206);

            passwordPicture.Image = Properties.Resources.password;
            passwordPanelLine.BackColor = Color.WhiteSmoke;
            passwordBox.ForeColor = Color.WhiteSmoke;
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            passwordBox.Clear();
            passwordPicture.Image = Properties.Resources.password_selected;
            passwordPanelLine.BackColor = Color.FromArgb(78, 184, 206);
            passwordBox.ForeColor = Color.FromArgb(78, 184, 206);
            passwordBox.UseSystemPasswordChar = true;

            usernamePicture.Image = Properties.Resources.username;
            usernamePanelLine.BackColor = Color.WhiteSmoke;
            usernameBox.ForeColor = Color.WhiteSmoke;
        }
    }
}
