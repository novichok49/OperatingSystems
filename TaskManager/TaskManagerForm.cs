using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManager
{
    public enum SizeProcess : int {Tiny,Small,Medium,Big,Extralarge}
    public partial class TaskManagerForm : Form
    {
        List<Process> Processes = new List<Process>();
        static bool Alg = true;
        static int CountA = 0;
        public TaskManagerForm()
        {
            InitializeComponent();
        }
        private void timerTicks_Tick(object sender, EventArgs e)
        {
            if (Processes.Count != 0) 
            {
                if (Alg == true)
                {
                    if (Processes[CountA].GetHealth() > 0)
                    {
                        Processes[CountA].SetHealth(Processes[CountA].GetHealth() - Process.SizeStep);
                        if (Processes[CountA].GetHealth() <= 0)
                        {
                            Processes.RemoveAt(CountA);
                        }
                    }
                    else
                    {
                        Processes.RemoveAt(CountA);
                    }
                }
                else
                {
                    if (Processes[CountA].GetHealth() > 0)
                    {
                        Processes[CountA].SetHealth(Processes[CountA].GetHealth() - Process.SizeStep);
                        if (Processes[CountA].GetHealth() <= 0)
                        {
                            Processes.RemoveAt(CountA);
                        }
                        else
                        {
                            CountA++;
                        }
                    }
                    else
                    {
                        Processes.RemoveAt(CountA);
                    }
                }
                if (CountA >= Processes.Count)
                {
                    CountA = 0;
                }
                listProcess.BeginUpdate();
                listProcess.Items.Clear();
                for (int i = 0; i < Processes.Count; i++)
                {
                    var async = new ListViewItem(new string[]
                    {
                    Processes[i].GetName(),
                    Processes[i].GetId().ToString(),
                    Processes[i].GetMemory().ToString()+"Мб",
                    Processes[i].GetHealth().ToString(),
                    Processes[i].GetCreateTime().ToString()
                    });
                    if (i == CountA)
                    { 
                        async.BackColor = Color.Green;
                    }
                    listProcess.Items.Add(async);
                }
                listProcess.EndUpdate();
            }
            else
            {
                Console.WriteLine("Таймер остановился");
                timerTicks.Stop();
            }
        }
        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            Processes.Add(new Process());
            try
            {
                if (textBox1.Text != "")
                {
                    Processes[Processes.Count - 1].SetName(textBox1.Text);
                }
                if (textBox2.Text != "")
                {
                    Processes[Processes.Count - 1].SetMemory(int.Parse(textBox2.Text));
                }
                if (textBox3.Text != "")
                {
                    Processes[Processes.Count - 1].SetHealth(int.Parse(textBox3.Text));
                }
            }
            catch
            {
                Console.WriteLine("Эй, введи числа в поля память и время работы");
            }
            listProcess.Items.Add(new ListViewItem(new string[] 
                {
                    Processes[Processes.Count-1].GetName(),
                    Processes[Processes.Count-1].GetId().ToString(),
                    Processes[Processes.Count-1].GetMemory().ToString()+"Мб",
                    Processes[Processes.Count-1].GetHealth().ToString(),
                    Processes[Processes.Count-1].GetCreateTime().ToString()
                }));
            if (!timerTicks.Enabled)
            {
                Console.WriteLine("Таймер стартанул");
                timerTicks.Start();
            }
            
        }
        private void buttonChangeAlg_Click(object sender, EventArgs e)
        {
            
            if (Alg == true)
            {
                label1.Text = "Алгоритм RR";
                Alg = false;
            }
            else
            {
                label1.Text = "Алгоритм FCFS";
                CountA = 0;
                Alg = true;
            }
        }
    }

    class Process
    {
        private int Memory;
        private int Health;
        private string Name;
        private int Id;
        private DateTime CreateTime;
        
        static private SizeProcess SizeTemporary;
        static private int Amount = 0;
        static private Random Randomize = new Random();
        static public int SizeStep = 15;

        public void SetName(string name) { Name = name; }
        public void SetId(int id) { Id = id; }
        public void SetMemory(int memory) { Memory = memory; }
        public void SetHealth(int health) { Health = health; }
        public  string GetName() { return  Name; }
        public int GetId() { return Id; }
        public int GetMemory() { return Memory; }
        public int GetHealth() { return Health; }
        public DateTime GetCreateTime() { return  CreateTime; }
        public Process()
        {
            Name = "Process";
            SizeTemporary = (SizeProcess)Randomize.Next(0,5);
            switch (SizeTemporary)
            {
                case SizeProcess.Tiny: { Memory = Randomize.Next(30,61); break; }
                case SizeProcess.Small: { Memory = Randomize.Next(61, 121); break; }
                case SizeProcess.Medium: { Memory = Randomize.Next(121, 241); break; }
                case SizeProcess.Big: { Memory = Randomize.Next(241, 481); break; }
                case SizeProcess.Extralarge: { Memory = Randomize.Next(481, 961); break; }
            }
            SizeTemporary = (SizeProcess)Randomize.Next(0, 5);
            switch (SizeTemporary)
            {
                case SizeProcess.Tiny: { Health = Randomize.Next(30, 61); break; }
                case SizeProcess.Small: { Health = Randomize.Next(61, 121); break; }
                case SizeProcess.Medium: { Health = Randomize.Next(121, 241); break; }
                case SizeProcess.Big: { Health = Randomize.Next(241, 481); break; }
                case SizeProcess.Extralarge: { Health = Randomize.Next(481, 961); break; }
            }
            Amount++;
            Name += Amount.ToString();
            Id = Amount;
            Name += SizeTemporary.ToString();
            CreateTime = DateTime.Now;
        }
    }
}