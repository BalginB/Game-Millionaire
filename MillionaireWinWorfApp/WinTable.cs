

namespace MillionaireWinWorfApp
{
    public class WinTable
    {
        int currentRowIndex = -1;
        public WinRow[] Wins {  get; set; }

        public WinRow GetCurrent() 
        { 

            if(currentRowIndex >= 0)
            {
                return Wins[currentRowIndex];
            }

            return null;
        }
        public WinTable() 
        {
            Wins = [
            new WinRow(100, false),
            new WinRow(200, false),
            new WinRow(300, false),
            new WinRow(500, false),
            new WinRow(1000, true),
            new WinRow(2000, false),
            new WinRow(4000, false),
            new WinRow(8000, false),
            new WinRow(16000, false),
            new WinRow(32000, true),
            new WinRow(64000, false),
            new WinRow(125000, false),
            new WinRow(250000, false),
            new WinRow(500000, false),
            new WinRow(1000000, true)
            ];
        }
        public void Next()
        {
            currentRowIndex++;
        }

        public void Lose()
        {
            for(int i = currentRowIndex; i >= 0; i--)
            {
                if (Wins[i].IsMilestone) 
                {
                    currentRowIndex = i;
                    return;
                }
            }
            currentRowIndex = -1;
        }
    }
}
