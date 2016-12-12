using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8Group3MVVM
{
    class WorldSeriesWinner : INotifyPropertyChanged
    {
        const string DATA_FILE_TEAMS = "Teams.txt";
        const string DATA_FILE_WINNER = "WorldSeriesWinners.txt";
        string[] teams;
        string[] winnerTeam;
        int totalNumberWin = 0;
        public List<string> Teams
        {
            get { return _Teams; }
            set { _Teams = value; OnPropertyChanged(); }
        }
        private List<string> _Teams;
        public string SelectedTeam
        {
            get { return _SelectedTeam; }
            set { _SelectedTeam = value; OnPropertyChanged(); }
        }
        private string _SelectedTeam;
        public string Result
        {
            get { return _Result; }
            set { _Result = value; OnPropertyChanged(); }
        }
        private string _Result;

        public WorldSeriesWinner()
        {
            teams = File.ReadAllLines(DATA_FILE_TEAMS);
            winnerTeam = File.ReadAllLines(DATA_FILE_WINNER);
            _Teams = teams.ToList();
            Teams = _Teams;
        }
        public void GetResult()
        {
            for (int i = 0; i < winnerTeam.Length; i++)
                {
                    if (_SelectedTeam == winnerTeam[i])
                        totalNumberWin = totalNumberWin + 1;
                }
                _Result = _SelectedTeam + " won " + totalNumberWin + " Times";
                Result = _Result;
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
