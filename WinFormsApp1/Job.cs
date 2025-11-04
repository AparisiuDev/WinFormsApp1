namespace WinFormsApp1
{
    internal class Job
    {
        public string Job_title { get; set; }
        public decimal? Min_salary { get; set; }
        public decimal? Max_salary { get; set; }

        public Job(string job, decimal? min, decimal? max) 
        {
            Job_title = job;
            Min_salary = min;
            Max_salary = max;
        }
    }
}
