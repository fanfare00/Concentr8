using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace JamesConcentrate.Data
{
    public class GameData
    {
        private int[] _InitialGridState;
        public int[] InitialGridState
        {
            get {return _InitialGridState;}
            set { _InitialGridState = value; }
        }

        private int _GameNumber;
        public int GameNumber
        {
            get { return _GameNumber; }
            set { _GameNumber = value; }
        }

        private int _Matches;
        public int Matches
        {
            get { return _Matches; }
            set { _Matches = value; }
        }

        private int _Mismatches;
        public int Mismatches
        {
            get { return _Mismatches; }
            set { _Mismatches = value; }
        }

        private string _Length;
        

        private IList _TurnHistory;
        public IList TurnHistory
        {
            get { return _TurnHistory; }
            set { _TurnHistory = value; }
        }

        private ArrayList _TurnSummary;
        public ArrayList TurnSummary
        {
            get { return _TurnSummary; }
            set { _TurnSummary = value; }
        }

        public GameData(int[] initialGridState, int gameNumber)
        {
            InitialGridState = initialGridState;
            GameNumber = gameNumber;
            TurnHistory = new ArrayList();
            TurnSummary = new ArrayList();

            Matches = 0;
            Mismatches = 0;
        }
    }
}
