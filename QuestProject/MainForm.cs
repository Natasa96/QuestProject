using Newtonsoft.Json;
using static QuestProject.ButtonActions;

namespace QuestProject
{
    public partial class QuestProject : Form
    {
        private ButtonActions _btnActions = new ButtonActions();
        private const string _cmbHeader = "Please select project...";


        public QuestProject()
        {
            InitializeComponent();

            setupCmb_RecenteProjects();
        }

        private void setupCmb_RecenteProjects()
        {
            cmb_RecentProjects.DataSource = populateCmbRecentProjects();

            cmb_RecentProjects.DisplayMember = _cmbHeader;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            openRecentProjectsFile();
        }

        private void btn_CreateNewProject_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm(_btnActions.ReadDefaultProject());
            projectForm.ShowDialog();
        }


        //Opening RecentProjects file for loading existing projects
        public void openRecentProjectsFile()
        {
            try
            {
                OpenFileDialog ofd = _btnActions.openRecentProjectsFolder();
                Parameters p = new Parameters();

                ofd.Title = "Please choose project you would like to load";

                if (ofd.ShowDialog() != DialogResult.OK)
                    throw new Exception();

                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                         p = jsonSerializer.Deserialize<Parameters>(reader) ?? new Parameters();

                        if (p == null)
                            throw new Exception();
                    }
                }

                ProjectForm projectForm = new ProjectForm(p);
                projectForm.ShowDialog();

                setupCmb_RecenteProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Getting .txt files from RecentProjects file for cmb_RecentProjects
        private List<string> populateCmbRecentProjects()
        {
            List<string> recentProjects = new List<string>()
            {
                _cmbHeader
            };

            var directoryRecentProjects = new DirectoryInfo(_btnActions.getRecentProjectsPath()).GetFiles().OrderByDescending(f => f.LastWriteTime).ToList();
            foreach (FileInfo file in directoryRecentProjects)
            {
                if (recentProjects.Count == _btnActions.GetNumberOfRecentFiles() + 1) 
                    return recentProjects;

                recentProjects.Add(file.Name.Split("\\").Last());
            }

            return recentProjects;
        }

        //Loading selected recent project
        private void cmb_RecentProjects_TextChanged(object sender, EventArgs e)
        {

            if (cmb_RecentProjects.SelectedItem.ToString() == _cmbHeader)
                return;

            try
            {
                Parameters p = new Parameters();
                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamReader sr = new StreamReader(_btnActions.getRecentProjectsPath() + "\\" + cmb_RecentProjects.SelectedValue))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        p = jsonSerializer.Deserialize<Parameters>(reader) ?? new Parameters();

                        if (p == null)
                            throw new Exception();

                    }
                }

                ProjectForm projectForm = new ProjectForm(p);
                projectForm.ShowDialog();

                setupCmb_RecenteProjects();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //Options for changing default values and changing number of recent files
        private void btn_Options_Click(object sender, EventArgs e)
        {
            OptionsForm opf = new OptionsForm();
            opf.ShowDialog();

            setupCmb_RecenteProjects();
        }
    }
}