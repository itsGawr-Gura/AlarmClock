using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class EditForm : Form
    {
        public Alarm EditedAlarm { get; private set; }
        public EditForm(Alarm alarm)
        {
            InitializeComponent();
            EditedAlarm = alarm;
            PopulateFields();
        }
        private void PopulateFields()
        {
            time.Text = EditedAlarm.Time;
            name.Text = EditedAlarm.Name;
            SetCheckedItems();
            active.Checked = EditedAlarm.Active;

        }
        private void SetCheckedItems()
        {
            string[] selectedItems = EditedAlarm.Periodicity.Split(',');
            for (int i = 0; i < periodicity.Items.Count; i++)
            {
                periodicity.SetItemChecked(i, Array.Exists(selectedItems, item => item.Trim() == periodicity.Items[i].ToString().Trim()));
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(time.Text) || string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedPeriodicity = string.Join(", ", GetCheckedItems());

            EditedAlarm.Time = time.Text;
            EditedAlarm.Name = name.Text;
            EditedAlarm.Periodicity = selectedPeriodicity;
            EditedAlarm.Active = active.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }
        private IEnumerable<string> GetCheckedItems()
        {
            var selectedItems = new List<string>();
            foreach (var item in periodicity.CheckedItems)
            {
                selectedItems.Add(item.ToString());
            }
            return selectedItems;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close(); 
        }
    }
}
