///This program was created by Alyssa Pogson
///on May 25 2018
///to provide a way for clients to check inventory securely 

using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSW_Inventory
{
    public partial class InventoryScreen : UserControl
    {
        //declare variables
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "GSW Inventory";
        public static List<Product> inventory = new List<Product>();
        string search;

        public InventoryScreen()
        {
            InitializeComponent();
            
            LoadInventory(Scopes);
            ShowInventory();
        }

        /// <summary>
        /// Sets enter press to activate search.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                searchButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Loads inventory from an outside source.
        /// </summary>
        /// <param name="args"></param>
        public static void LoadInventory(string[] args)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            //define request parameters
            String spreadsheetId = "1ZpvKvq-X1wx153NMTwFyvOBgcw7FU8C2S427AGdIJSI";
            String range = LoginScreen.company + "!A2:C";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            //retrieve values and put in list
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    Product p = new Product(Convert.ToString(row[0]), Convert.ToString(row[1]), Convert.ToInt32(row[2]));
                    inventory.Add(p);
                }                
            }
        }

        /// <summary>
        /// Displays inventory list to the data table.
        /// </summary>
        public void ShowInventory()
        {
            foreach (Product p in inventory)
            {              
                showProducts.Rows.Add(p.code, p.description, p.stock);
            }
        }

        /// <summary>
        /// Searches for a specific item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            search = searchBox.Text;
            searchBox.Clear();

            foreach (Product p in inventory)
            {
                if (p.code.Contains(search))
                {
                    showProducts.Rows.Clear();
                    showProducts.Rows.Add(p.code, p.description, p.stock);
                    errorLabel.Visible = false;
                    break;
                }
                else
                {
                    errorLabel.Visible = true;
                }
            }

        }

        /// <summary>
        /// Removes the search and displays all inventory again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xButton_Click(object sender, EventArgs e)
        {
            //remove search and display inventory again
            errorLabel.Visible = false;
            showProducts.Rows.Clear();
            ShowInventory();
        }

        /// <summary>
        /// Returns the user to LoginScreen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            LoginScreen ls = new LoginScreen();
            f.Controls.Add(ls);
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);

        }
    }
}
