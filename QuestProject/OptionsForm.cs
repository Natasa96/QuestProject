using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestProject
{
    public partial class OptionsForm : Form
    {
        private Parameters _parameters = new Parameters();
        private ButtonActions _btnActions = new ButtonActions();
        private int _numOfFiles = 5;

        public int NumberOfFiles
        {
            get { return _numOfFiles; }
            set { _numOfFiles = value; }
        }

        public OptionsForm()
        {
            InitializeComponent();

            bindingControl(_parameters);

            Parameters p = _btnActions.ReadDefaultProject();
            _parameters.ServerName = p.ServerName;
            _parameters.Username = p.Username;
            _parameters.DatabaseName = p.DatabaseName;
            _parameters.Password = p.Password;
            _parameters.ParametersInfo = p.ParametersInfo;

            NumberOfFiles = _btnActions.GetNumberOfRecentFiles();
            nud_RecentFiles.Value = NumberOfFiles;
        }

        //Bindings for Parametars class
        private void bindingControl(Parameters parameters)
        {
            txb_ServerNameOptions.DataBindings.Clear();
            txb_UsernameOptions.DataBindings.Clear();
            txb_DatabaseNameOptions.DataBindings.Clear();
            txb_PasswordOptions.DataBindings.Clear();
            rtb_ParametersOptions.DataBindings.Clear();

            txb_ServerNameOptions.DataBindings.Add("Text", parameters, "ServerName", true, DataSourceUpdateMode.OnPropertyChanged);
            txb_UsernameOptions.DataBindings.Add("Text", parameters, "Username", true, DataSourceUpdateMode.OnPropertyChanged);
            txb_DatabaseNameOptions.DataBindings.Add("Text", parameters, "DatabaseName", true, DataSourceUpdateMode.OnPropertyChanged);
            txb_PasswordOptions.DataBindings.Add("Text", parameters, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
            rtb_ParametersOptions.DataBindings.Add("Text", parameters, "ParametersInfo", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        //Saving all parametars to default 
        private void btn_Change_Click(object sender, EventArgs e)
        {
            try
            {
                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(_btnActions.getConfigPath() + _btnActions.DefaultProjectName))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        jsonSerializer.Serialize(writer, _parameters);
                    }
                }

                using (StreamWriter sw = new StreamWriter(_btnActions.getConfigPath() + _btnActions.ConfigFileName))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        jsonSerializer.Serialize(writer, Convert.ToInt32(nud_RecentFiles.Value));
                    }
                }

                MessageBox.Show("Successfully saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
