using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesConcentrate.Data
{
    public class TurnData
    {
        private int _TurnNumber;
        public int TurnNumber
        {
            get { return _TurnNumber; }
            set { _TurnNumber = value; }
        }

        private int _PictureClicked1;
        public int PictureClicked1
        {
            get { return _PictureClicked1; }
            set { _PictureClicked1 = value; }
        }

        private int _PicutreClicked2;
        public int PictureClicked2
        {
            get { return _PicutreClicked2; }
            set { _PicutreClicked2 = value; }
        }

        private bool _IsMatch;
        public bool IsMatch
        {
            get { return _IsMatch; }
            set { _IsMatch = value; }
        }

        private bool _Completed;
        public bool Completed
        {
            get { return _Completed; }
            set { _Completed = value; }
        }

        //private int _TurnState;
        //public int TurnState
        //{
        //    get { return _TurnState; }
        //    set { _TurnState = value; }
        //}

        public TurnData(int turnNumber,  int pictureClicked1, int pictureClicked2, bool isMatch)
        {
            TurnNumber = turnNumber;
            PictureClicked1 = pictureClicked1;
            PictureClicked2 = pictureClicked2;
            IsMatch = isMatch;
            Completed = false;
  
        }
    }
}
