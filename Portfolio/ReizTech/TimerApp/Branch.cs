namespace TimerApp
{
    public class Branch
    {
        public List<Branch> Branches { get; set; }

        public Branch()
        {
            Branches = new List<Branch>();
        }
    }
}
