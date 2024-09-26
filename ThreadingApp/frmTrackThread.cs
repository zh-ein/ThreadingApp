namespace ThreadingApp
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");


            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";
            threadA.Priority = ThreadPriority.Highest;

            Thread threadB = new Thread(MyThreadClass.Thread2);
            threadB.Name = "Thread B";
            threadB.Priority = ThreadPriority.Normal;

            Thread threadC = new Thread(MyThreadClass.Thread1);
            threadC.Name = "Thread C";
            threadC.Priority = ThreadPriority.AboveNormal;

            Thread threadD = new Thread(MyThreadClass.Thread2);
            threadD.Name = "Thread D";
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End Of Thread-";
        }
    }
}
    

