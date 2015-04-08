using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JamesConcentrate.Data;

namespace JamesConcentrate.Controller
{
    public class JamesDataController
    {
        IMainForm _mainForm;
        IList _gameData;
        IList _turnData;

        GameData _currentGame;
        TurnData _currentTurn;

        //GameData _currentReplayGame;
        //TurnData _currentReplayTurn;

        bool _haveCurrentTurn = false;
        

        public JamesDataController(IMainForm mainForm, IList gameData)
        {
            _mainForm = mainForm;
            _gameData = gameData;
            _turnData = new ArrayList();

            _mainForm.SetController(this);
        }

        public IList GameData
        {
            get { return ArrayList.ReadOnly(_gameData); }
        }

        public void LoadNewGameState()
        {
            int[] imageValues = new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
          
            Shuffle<int>(imageValues);

            _currentGame = new GameData(imageValues, _gameData.Count + 1);
            _currentTurn = null;

            _mainForm.StartNewGame(_currentGame);
            _mainForm.UpdateGameInfo(_currentGame);

            _haveCurrentTurn = false;
        }

        public void DisplayStartingState()
        {
            _mainForm.StartNewGame(_currentGame);
        }

        public void DisplayCurrentState()
        {
            if (_currentTurn == null)
            {
                _mainForm.HideAllImages();
                return;
            }

            _mainForm.UpdateGrid(_currentGame.InitialGridState, _currentGame.TurnHistory, _currentTurn);
        }

        public void AddPreviousGameToHistory()
        {
            if (_currentGame != null)
            {
                _gameData.Add(_currentGame);
                _mainForm.UpdateGameHistory(_currentGame);
            }

        }

        public void AddNewTurn(int imageNumber)
        {
            if (_currentGame == null)
            {
                return;
            }

            if ((_currentTurn != null) && (_currentTurn.Completed == true))
            {
                _currentTurn.PictureClicked2 = imageNumber;
                _currentGame.TurnSummary.Add("Turn " + _currentTurn.TurnNumber.ToString() + ": Box " + ((_currentTurn.PictureClicked2+1)).ToString() + " was clicked.");
                compareImages(_currentTurn.PictureClicked1, _currentTurn.PictureClicked2);
                _mainForm.UpdateGameInfo(_currentGame);
                _currentGame.TurnHistory.Add(_currentTurn);
                _mainForm.UpdateGrid(_currentGame.InitialGridState, _currentGame.TurnHistory, _currentTurn);
                //_currentTurn.Completed = false;
            }
            else
            {
                _currentTurn = new TurnData(_currentGame.TurnHistory.Count+1, 0, -1, true);
                _currentTurn.PictureClicked1 = imageNumber;

                _mainForm.UpdateGrid(_currentGame.InitialGridState, _currentGame.TurnHistory, _currentTurn);
                _currentGame.TurnSummary.Add("Turn " + _currentTurn.TurnNumber.ToString() + ": Box " + ((_currentTurn.PictureClicked1+1)).ToString() + " was clicked.");
                _mainForm.UpdateGameInfo(_currentGame);

                //_currentTurn.Completed = true;
            }

            _currentTurn.Completed = !_currentTurn.Completed;
            //_haveCurrentTurn = !_haveCurrentTurn;
        }
        IList replayTurns = new ArrayList();
        

        public void ReverseTurn()
        {

               
            if ((_currentTurn != null) && (_currentTurn.Completed == true))
            {
                replayTurns.Clear();

                for (int i = 0; i < _currentGame.TurnHistory.IndexOf(_currentTurn); i++)
                {
                    replayTurns.Add(_currentGame.TurnHistory[i]);
                }

                _mainForm.UpdateGrid(_currentGame.InitialGridState, replayTurns, _currentTurn);
                //_currentTurn.Completed = false;
            }
            else
            {
                if (_currentTurn.TurnNumber > 1)
                {
                    _currentTurn = (TurnData)_currentGame.TurnHistory[_currentGame.TurnHistory.IndexOf(_currentTurn) - 1];
                }

                for (int i = 0; i < _currentGame.TurnHistory.IndexOf(_currentTurn); i++)
                {
                    replayTurns.Add(_currentGame.TurnHistory[i]);
                }
                _mainForm.UpdateGrid(_currentGame.InitialGridState, replayTurns, _currentTurn);
                
            }
            _currentTurn.Completed = !_currentTurn.Completed;
            
        }

        private void compareImages(int image1, int image2)
        {
            if (_currentGame.InitialGridState[image1] == _currentGame.InitialGridState[image2])
            {      
                _currentTurn.IsMatch = true;
                _currentGame.Matches += 1;
                _currentGame.TurnSummary.Add("Turn " + _currentTurn.TurnNumber.ToString() + ": MATCH!");
                _mainForm.UpdateTotalMatches();
            }
            else
            {
                _currentTurn.IsMatch = false;
                _currentGame.Mismatches += 1;
                _currentGame.TurnSummary.Add("Turn " + _currentTurn.TurnNumber.ToString() + ": NO MATCH.");
                _mainForm.UpdateTotalMismatches();
            }

            _mainForm.UpdateTotalMatchRate();
        }

        private void Shuffle<T>(T[] array)
        {
            System.Random rnd = new System.Random();

            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(rnd.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }


        public void AddNewTurn()
        {
           // _currentTurn = new TurnData(null);
        }
    }
}
