namespace MillionaireWinWorfApp
{
    public class WinRow
    {
        public decimal Count { get; set; }
        public bool IsMilestone { get; set; }

        public WinRow(decimal count, bool isMilestone)
        {
            Count = count;
            IsMilestone = isMilestone;
        }
    }
}
