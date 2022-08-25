using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PingTest
{
    public partial class Form1 : Form
    {
        private bool Loading = false;
        private int PacketLoss = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Loading == false && Adress.ReadOnly == false && Adress.Text.Length >= 1)
            {
                Start.Text = "Stop";
                Adress.ReadOnly = true;
                Loading = true;
                Box.Items.Clear();
                ProgressBar.Value = 0;

                PacketLoss = 0;
                Minimum.Text = "Minimum:";
                Maximum.Text = "Maximum:";
                Average.Text = "Average:";
                Loss.Text = "Loss:";

                BWPing.RunWorkerAsync();
            }
            else
            {
                Loading = false;
            }
        }

        private void BWPing_DoWork(object sender, DoWorkEventArgs e)
        {
            string host = Adress.Text;
            int timeout = 1000;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            for (int i = 0; i < 10; ++i)
            {
                if (Loading == false)
                {
                    break;      
                }

               using Ping p = new();
               {
                    try
                    {
                        PingReply reply = p.Send(host, timeout, buffer);

                        if (Box.InvokeRequired)
                        {
                        if (reply.Status == IPStatus.Success)

                        {
                        _ = Box.Invoke(new MethodInvoker(delegate
                        {
                            Box.Items.Add(reply.RoundtripTime.ToString());

                            IEnumerable<int> numbers = Box.Items.Cast<object>().Select(obj => Convert.ToInt32(obj));
                            int min = numbers.Min();
                            int max = numbers.Max();

                            int media = numbers.Sum() / numbers.Count();

                            Minimum.Text = "Minimum: " + min;
                            Maximum.Text = "Maximum: " + max;
                            Average.Text = "Average: " + media;

                            ProgressBar.Increment(1);
                            }));

                            }
                            else
                            {
                                _ = Box.Invoke(new MethodInvoker(delegate
                                {
                                    PacketLoss++;
                                    ProgressBar.Increment(1);
                                    Loss.Text = "Loss: " + PacketLoss.ToString();
                                }));
                            }
                        }
                    }
                    catch (PingException)
                    {
                        DialogResult = MessageBox.Show("Please check the address entered and that you are connected to the internet.", "PingTest");
                        break;
                    }
               }
               Thread.Sleep(500);
            }
        }

        private void BWPing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Adress.ReadOnly = false;
            Loading = false;
            Start.Text = "Start";
            ProgressBar.Value = 10;
        }
    }
}
