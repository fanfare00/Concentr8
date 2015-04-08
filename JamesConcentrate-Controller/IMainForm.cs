using System;
using JamesConcentrate.Data;
using System.Collections;

namespace JamesConcentrate.Controller
{
    public interface IMainForm
    {
        void SetController(JamesDataController controller);
       // void UpdateGameState(TurnData turn);
        void StartNewGame(GameData game);
        void UpdateGrid(int[] gridState, IList turns, TurnData currentTurn);
        void ShowClickedImage(int[] gridState, int imageClicked);
        void HideAllImages();
        void ShowWrongImage(int imageClicked);
        void UpdateGameHistory(GameData game);
        void UpdateGameInfo(GameData game);

        void UpdateTotalMatches();
        void UpdateTotalMismatches();
        void UpdateTotalMatchRate();

        int ReplayTurnNumber { get; set; }
    }
}
