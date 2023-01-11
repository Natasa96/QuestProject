using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestProject
{
    
    public class Parameters : INotifyPropertyChanged
    {
        private string? _serverName;
        private string? _username;
        private string? _password;
        private string? _databaseName;
        private string? _parametersInfo;

        #region Properties
        public string? ServerName {
            get
            {
                return _serverName;
            }
            set
            {
                if (value == ServerName)
                    return;
                _serverName = value;
                OnPropertyChanged("ServerName");
            }
        }
        public string? DatabaseName 
        {
            get 
            {
                return _databaseName;    
            } 
            set
            {
                if (value == DatabaseName)
                    return;
                _databaseName = value;
                OnPropertyChanged("DatabaseName");
            }
        }
        public string? Username 
        {
            get
            {
                return _username;
            }
            set 
            {
                if (value == Username)
                    return;
                _username = value;
                OnPropertyChanged("Username");
            } 
        }
        public string? Password
        {
            get 
            { 
                return _password; 
            }
            set
            {
                if (value == Password)
                    return;
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        public string? ParametersInfo
        {
            get 
            {
                return _parametersInfo;

            }
            set
            {
                _parametersInfo = value;
                OnPropertyChanged("ParametersInfo");
            }
        }

        #endregion

        public Parameters(string ServerName, string DatabaseName, string Username, string Password, string Parameters)
        {
            this.ServerName = ServerName;
            this.DatabaseName = DatabaseName;
            this.Username = Username;
            this.Password = Password;
            this.ParametersInfo = Parameters;
        }

        public Parameters()
        {
            this.ServerName = string.Empty;
            this.DatabaseName = string.Empty;
            this.Username = string.Empty;
            this.Password = string.Empty;
            this.ParametersInfo = string.Empty;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string GetInfo()
        {
            return this.DatabaseName + " " + this.ServerName + " " + this.Username + " " + this.Password;
        }
    }
}
