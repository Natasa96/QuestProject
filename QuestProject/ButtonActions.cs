using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestProject
{
    public class ButtonActions
    {
        public string ConfigFileName = "\\Config.txt";
        public string DefaultProjectName = "\\DefaultProject.txt";

        //Finding path for RecentProjects file
        public string getRecentProjectsPath()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "QuestProject\\RecenteProjects");
            return path;
        }

        //Finding path for Config folder
        public string getConfigPath()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "QuestProject\\Config");
            return path;
        }

        //Opening RecentProjects folder
        public OpenFileDialog openRecentProjectsFolder()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = getRecentProjectsPath();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            return openFileDialog;
        }

        //Getting default project parameters
        public Parameters ReadDefaultProject()
        {
            try
            {

                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamReader sr = new StreamReader(getConfigPath() + DefaultProjectName))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        return jsonSerializer.Deserialize<Parameters>(reader) ?? new Parameters();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new Parameters();
            }
        }

        //Getting number of recent files
        public int GetNumberOfRecentFiles()
        {
            try
            {

                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamReader sr = new StreamReader(getConfigPath() + ConfigFileName))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        int num = jsonSerializer.Deserialize<int?>(reader) ?? 5;
                        return num;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 5;
            }
        }
    }
}
