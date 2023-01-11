using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestProject.ButtonActions;

namespace QuestProject
{
    public partial class ProjectForm : Form
    {
        private Parameters _parameters = new Parameters();
        private ButtonActions _btnActions = new ButtonActions();

        public ProjectForm()
        {
            InitializeComponent();

            bindingControl(_parameters);
        }

        public ProjectForm(Parameters p)
        {
            InitializeComponent();
            _parameters.ServerName = p.ServerName;
            _parameters.Username = p.Username;
            _parameters.DatabaseName = p.DatabaseName;
            _parameters.Password = p.Password;
            _parameters.ParametersInfo = p.ParametersInfo;
            bindingControl(_parameters);
        }

        //Bindings for Parametars class
        private void bindingControl(Parameters parameters)
        {
            txb_ServerName.DataBindings.Clear();
            txb_Username.DataBindings.Clear();
            txb_DatabaseName.DataBindings.Clear();
            txb_Password.DataBindings.Clear();
            txb_Parameters.DataBindings.Clear();

            txb_ServerName.DataBindings.Add("Text", parameters, "ServerName", true, DataSourceUpdateMode.OnPropertyChanged);
            txb_Username.DataBindings.Add("Text", parameters, "Username", true, DataSourceUpdateMode.OnPropertyChanged);
            txb_DatabaseName.DataBindings.Add("Text", parameters, "DatabaseName", true, DataSourceUpdateMode.OnPropertyChanged);
            txb_Password.DataBindings.Add("Text", parameters, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
            txb_Parameters.DataBindings.Add("Text", parameters, "ParametersInfo", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        //Saving .txt file to RecentProjects folder
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(_btnActions.getRecentProjectsPath() + "\\" + _parameters.ServerName + ".txt"))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        jsonSerializer.Serialize(writer, _parameters);
                    }
                }
                MessageBox.Show("Successfully saved file!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Saving .txt file to wanted folder with wanted name
        private void btn_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.Title = "Save project";
            sfd.ShowDialog();

            if(sfd.FileName != "")
            {
                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        jsonSerializer.Serialize(writer, _parameters);
                    }
                }
                MessageBox.Show("Successfully saved file!");
            }
        }

        //Loading existing .txt file on to ProjectForm
        private void btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = _btnActions.openRecentProjectsFolder();

                ofd.Title = "Please choose project you would like to load";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        Parameters p = jsonSerializer.Deserialize<Parameters>(reader) ?? new Parameters ();
                        
                        if (p == null)
                            throw new Exception();

                        _parameters.ServerName = p.ServerName;
                        _parameters.Username = p.Username;
                        _parameters.DatabaseName = p.DatabaseName;
                        _parameters.Password = p.Password;
                        _parameters.ParametersInfo = p.ParametersInfo;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clearing all parameters 
        private void btn_New_Click(object sender, EventArgs e)
        {
            _parameters.ServerName = String.Empty;
            _parameters.Username = String.Empty;
            _parameters.DatabaseName = String.Empty;
            _parameters.Password = String.Empty;
            _parameters.ParametersInfo = String.Empty;
        }

    }
}
