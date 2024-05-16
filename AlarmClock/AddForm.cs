using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class AddForm : Form
    {
        public Alarm NewAlarm { get; private set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(time.Text) || string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedItems = new List<string>();
            foreach (var item in periodicity.CheckedItems)
            {
                selectedItems.Add(item.ToString());
            }
            string selectedPeriodicity = string.Join(", ", selectedItems);

            NewAlarm = new Alarm(time.Text, name.Text, selectedPeriodicity, active.Checked);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close(); 
        }
    }
}
