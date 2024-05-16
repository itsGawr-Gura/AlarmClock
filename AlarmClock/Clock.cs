using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Clock : Form
    {
        private List<Alarm> alarms;
        public Clock()
        {
            InitializeComponent();
            alarms = new List<Alarm>();
            LoadAlarms();
            InitializeDataGridView();

 
        }
        private void LoadAlarms()
        {
            alarms.Add(new Alarm("08:00", "Утро", "Пон", true));
            alarms.Add(new Alarm("12:00", "Пора кушать", "Субб", true));
            alarms.Add(new Alarm("18:00", "Ужин", "Воскр", true));
        }
        private void InitializeDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Add("Time", "Время");
            dataGridView.Columns.Add("Name", "Название");
            dataGridView.Columns.Add("Periodicity", "Периодичность");
            dataGridView.Columns.Add("Active", "Вкл/Выкл");
            UpdateDataGridView();            
           
        }
        private void UpdateDataGridView()
        {
            dataGridView.Rows.Clear();

            foreach (var alarm in alarms)
            {
                dataGridView.Rows.Add(alarm.Time, alarm.Name, alarm.Periodicity, alarm.Active ? "Вкл" : "Выкл");
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                alarms.Add(addForm.NewAlarm);
                UpdateDataGridView();
            }
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count - 1)
            {
                int selectedIndex = e.RowIndex;
                EditForm editForm = new EditForm(alarms[selectedIndex]);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    alarms[selectedIndex] = editForm.EditedAlarm;
                    UpdateDataGridView();
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = dataGridView.SelectedRows[0].Index;
                    string alarmName = dataGridView.Rows[selectedIndex].Cells["Name"].Value.ToString();
                    DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить будильник'{alarmName}'?", "Удаление будильника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        alarms.RemoveAt(selectedIndex);
                        UpdateDataGridView();
                    }

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Пожалуйста выберите будильник для удаления", "Удаление будильника", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
               
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите будильник для удаления", "Удаление будильника", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

    }
    public class Alarm
    {
        public string Time { get; set; }
        public string Name { get; set; }
        public string Periodicity { get; set; }
        public bool Active { get; set; }

        public Alarm(string time, string name, string periodicity, bool active)
        {
            Time = time;
            Name = name;
            Periodicity = periodicity;
            Active = active;
        }
    }
}
