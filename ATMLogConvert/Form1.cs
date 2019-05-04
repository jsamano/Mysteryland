using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ATMLogConvert
{
    public partial class Form1 : Form
    {
        private Converter converter;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs;
                    StreamReader sr;
                    try
                    {
                        fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        sr = new StreamReader(fs);

                        string receiverAccount;
                        string dateStartPeriod;
                        string dateEndPeriod;
                        int amountOfDeposits;

                        int visitorID;
                        decimal depositAmount;
                        List<Deposit> deposits = new List<Deposit>();


                        string line = sr.ReadLine();
                            receiverAccount = line;
                            line = sr.ReadLine();
                            dateStartPeriod = line;
                            line = sr.ReadLine();
                            dateEndPeriod = line;
                            line = sr.ReadLine();
                            amountOfDeposits = Convert.ToInt32(line);
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            visitorID = Convert.ToInt32(line.Split(' ')[0]);
                            depositAmount = Convert.ToDecimal(line.Split(' ')[1]);
                            deposits.Add(new Deposit(visitorID, depositAmount));
                            line = sr.ReadLine();
                        }
                        converter = new Converter(receiverAccount, dateStartPeriod, dateEndPeriod, amountOfDeposits, deposits);
                        if (converter.InsertData())
                        {
                            MessageBox.Show("Log processed sucessfully.");
                            lblLatestConvert.Text = DateTime.Now.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong processing the log.");
                        }

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file.");
                    }
                }
            }
        }
    }
}
